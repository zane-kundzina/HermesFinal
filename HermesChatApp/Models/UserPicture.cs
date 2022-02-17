using System.ComponentModel.DataAnnotations;

namespace HermesChatLoginUI.Models
{
    public class UserPicture
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }



    }
}
