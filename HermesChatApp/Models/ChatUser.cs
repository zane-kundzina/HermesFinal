using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;


namespace HermesChatLoginUI.Models
{
    public class ChatUser
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public int ChatId { get; set; }
        public Chat Chat { get; set; }
        public UserRole Role { get; set; }

        [DisplayName("Upload Image")]
        public string ImagePath { get; set; }

       // public IFormFile ImageFile { get; set; }
    }
}
