using System.ComponentModel.DataAnnotations;

namespace MVCMessageWall.Models
{
    public class MessageModel
    {
        [Required]
        [StringLength(10, MinimumLength = 3)]
        [Display(Name = "User Message")]
        public string Message { get; set; }
    }
}
