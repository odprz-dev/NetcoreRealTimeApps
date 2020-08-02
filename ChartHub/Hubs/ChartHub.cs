using ChrtHub.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChrtHub.Hubs
{
    public class ChartHb: Hub
    {
        public async Task BroadcastChartData(List<ChartModel> data) =>
            await Clients.All.SendAsync("broadcastchartdata", data);
    }
}
