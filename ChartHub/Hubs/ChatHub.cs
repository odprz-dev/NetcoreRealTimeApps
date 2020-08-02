using ChrtHub.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChrtHub.Hubs
{
    public class ChatHub: Hub
    {
        public async Task SendMessage(ChatMessage chatMessage)
        {
            await Clients.All.SendAsync("ReciveMessage", chatMessage);
        }
    }
}
