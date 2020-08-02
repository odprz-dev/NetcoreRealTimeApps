using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChrtHub.Models
{
    public class ChatMessage
    {
        public string Usuario { get; set; }
        public string Mensaje { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
