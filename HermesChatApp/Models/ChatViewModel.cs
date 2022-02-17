using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HermesChatLoginUI.Models
{
    public class ChatViewModel
    {
        public IEnumerable<Chat> Chats { get; set; }
        public Chat ActiveChat { get; set; }
    }
}
