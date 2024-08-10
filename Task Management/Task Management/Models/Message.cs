using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public string MessageText { get; set; }
        public DateTime Timestamp { get; set; }
        public bool IsRead { get; set; }
    }

}
