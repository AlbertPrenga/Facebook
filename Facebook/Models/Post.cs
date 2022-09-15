using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Facebook .Models;
#pragma warning disable CS8618

public class Post

{   
    [Key]
    public int PostId {get; set;}
    public int UserId {get; set;}
    public string Comment {get; set;}
    
    public User? Creator {get; set;}
   
    public List<Fan>? Fans = new List<Fan>();
    public List<Request>? miqte = new List<Request>();
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}