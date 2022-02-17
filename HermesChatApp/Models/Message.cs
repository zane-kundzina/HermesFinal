using System;
using System.ComponentModel.DataAnnotations;

namespace HermesChatLoginUI.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Text { get; set; }

        public DateTime Timestamp { get; set; }

        public int ChatId { get; set; }

        public Chat Chat { get; set; }


               
    }
}
