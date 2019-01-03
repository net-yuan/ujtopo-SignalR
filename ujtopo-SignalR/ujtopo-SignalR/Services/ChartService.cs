﻿using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;
using ujtopo.SignalR.Hubs;

namespace ujtopo.SignalR.Services
{
    /// <summary>
    /// 模拟数据类
    /// </summary>
    public static class D
    {
        public static int Count { get; set; }
    }

    /// <summary>
    /// 服务类
    /// </summary>
    public class ChartService
    {
        public async Task NotifyUpdates()
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<ChartHub>();
            if (hubContext != null)
            {
                var stats = await this.GetCount();
                hubContext.Clients.All.updateChart(stats);
            }
        }

        public async Task<int> GetCount()
        {
            return D.Count;
        }

        public async Task<int> IncreaceCount()
        {
            D.Count = D.Count + 1;
            return D.Count;
        }
    }
}