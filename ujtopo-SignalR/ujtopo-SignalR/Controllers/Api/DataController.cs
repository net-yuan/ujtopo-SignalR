﻿using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ujtopo.SignalR.Services;

namespace ujtopo.SignalR.Controllers.Api
{
    public class DataController : ApiController
    {
        private ChartService chartService;

        public DataController()
        {
            this.chartService = new ChartService();
        }

        // POST api/<controller>
        public async Task<HttpResponseMessage> Post()
        {
            var isCorrect = await this.chartService.IncreaceCount();

            await this.chartService.NotifyUpdates();

            return Request.CreateResponse(HttpStatusCode.Created, isCorrect);
        }
    }
}