﻿using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using Traversal.SignalRApi.Model;

namespace Traversal.SignalRApi.Hubs
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
            await Clients.All.SendAsync("CallVisitList", "bbb");
        }
    }
}
