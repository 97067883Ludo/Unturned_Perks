using System.ComponentModel.DataAnnotations;

namespace Reinier.Perks.Models;

public class ActiveConnection
{
    [Key]
    public int Id { get; set; }

    public int UserId { get; set; }
}