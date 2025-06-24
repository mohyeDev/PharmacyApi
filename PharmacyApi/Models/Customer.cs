using System.ComponentModel.DataAnnotations;

namespace PharmacyApi.Models;

public class Customer
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Customer Name Is Required")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "Contact Info is Required")]
    [StringLength(100,ErrorMessage = "Contact info must be up to 100 characters long.")]
    public string ContactInfo { get; set; }
    
    [StringLength(200,ErrorMessage = "Address Must Be up to 200 Characters Long.")]
    public string? Address { get; set; }

    public DateTime RegistrationDate { get; set; } = DateTime.Now;
}