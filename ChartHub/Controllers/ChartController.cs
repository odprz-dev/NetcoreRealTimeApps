using System;
using System.Collections.Generic;
using System.Linq;
using ChrtHub.DataStorgae;
using ChrtHub.Hubs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalRChatASP.TimeFeatures;

namespace ChrtHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartController : ControllerBase
    {
        private readonly IHubContext<ChartHb> _hub;

        public ChartController(IHubContext<ChartHb> hub)
        {
            _hub = hub;
        }

        public ActionResult GetInfo()
        {
            var timerMannager = new TimerManager(() => _hub.Clients.All.SendAsync("transferChartData", DataManager.GetData()));

            return Ok(new { Mesage = "Request Completed" });
        }
    }
}