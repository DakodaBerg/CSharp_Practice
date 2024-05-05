using System.ComponentModel.DataAnnotations;

namespace BlazorServerMessageWall.Models;


public class MessageModel
{
    [Required]
    public string? Message { get; set; } 

}
