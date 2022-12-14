using System.ComponentModel.DataAnnotations;
namespace Facebook.Models;
#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations.Schema;


public class User
{
    [Key]
    public int UserId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description {get; set;}
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    
    [DataType(DataType.Password)]
    [Required]
    [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
    public string Password { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public List<Post> Posts {get; set;}= new List<Post>();
    
    public List<Fan>? PosteQePelqej {get; set;}

    // [InverseProperty("Fans")]
    // public List<Fan>? Fans {get; set;}
     
    public List<Request>? Requests {get;set;}


    // public List<Like> Liked { get; set; } = new List<Like>(); 
    // Will not be mapped to your users table!
    [NotMapped]
    [Compare("Password")]
    [DataType(DataType.Password)]
    public string Confirm { get; set; }
}
public class LoginUser
{
    // No other fields!
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}