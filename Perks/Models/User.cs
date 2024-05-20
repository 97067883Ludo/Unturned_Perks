using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reinier.Perks.Models;

public class User
{
    [Key]
    public int Id { get; set; }
    
    public int ActivePerk { get; set; }
    
    
}