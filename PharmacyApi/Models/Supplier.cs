using System.ComponentModel.DataAnnotations;

namespace PharmacyApi.Models;

public class Supplier
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Supplier name is required.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Contact info is required.")]
    public string ContactInfo { get; set; }
    
    public string? Address { get; set; }
}