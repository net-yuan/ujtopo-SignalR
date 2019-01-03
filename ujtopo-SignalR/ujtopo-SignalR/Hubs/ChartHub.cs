using Microsoft.AspNet.SignalR;

namespace ujtopo.SignalR.Hubs
{
    public class ChartHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}