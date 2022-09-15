using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Facebook .Models;
#pragma warning disable CS8618

public class Fan

{   
    [Key]
    public int FanId {get; set;}
    public int PostId {get; set;}
    public int UserId {get; set;}
    
    // public User? Creator {get; set;}
   public User? UseriQePelqen {get; set;}
    public Post? PostiQePelqehet {get; set;}
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}