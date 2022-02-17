using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace HermesChatLoginUI.Models
{
    public class User : IdentityUser
    {
        public ICollection<ChatUser> Chats { get; set; }
        public User() : base()
        {
            Chats = new List<ChatUser>();
        }
    }
}
