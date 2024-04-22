using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reinier.Perks.Models;

public class UserConnection
{
    public int Id { get; set; }
    
    public string UserId { get; set; } = string.Empty;
    
    public string UserType { get; set; } = string.Empty;
}