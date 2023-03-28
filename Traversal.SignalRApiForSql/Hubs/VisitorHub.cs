using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using Traversal.SignalRApiForSql.Models;

namespace Traversal.SignalRApiForSql.Hubs
{
    public class VisitorHub : Hub
    {
        private readonly VisitorService _visitorService;
        
        public VisitorHub(VisitorService visitorService)
        {
            _visitorService = visitorService;
        }
        
        public async Task GetVisitorList()
        {
            await Clients.All.SendAsync("ReceiveVisitorList", _visitorService.GetVisitorChartList());
        }
    }
}
