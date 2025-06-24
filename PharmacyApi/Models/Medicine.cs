using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PharmacyApi.Models;

public class Medicine
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [StringLength(13)]
    public string? InternationalBarcode { get; set; } = null;
    public string? ActiveIngredient { get; set; }
    [Required]
    [Range(1,99999999)]
    public decimal Price { get; set; }
    
    [Range(0,9999)]
    public int StockQuantity { get; set; }
    
    [Required]
    
    public DateTime ExpiryDate { get; set; }
        
}