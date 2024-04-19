using System.ComponentModel.DataAnnotations;

namespace Reinier.Perks.Models;

public class UserConnection
{
    [Key]
    public int Id { get; set; }
    
    [MaxLength(255)]
    public string UserId { get; set; } = string.Empty;
	
    [MaxLength(255)]
    public string UserType { get; set; } = string.Empty;
}