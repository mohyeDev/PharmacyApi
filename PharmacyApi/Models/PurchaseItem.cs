using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyApi.Models;

public class PurchaseItem
{
    
    public int Id { get; set; }
        
    [Required]
    [ForeignKey("Purchase")]
    public int PurchaseId { get; set; }
    public Purchase Purchase { get; set; } = null;
    
    [Required]
    [ForeignKey("Medicine")]
    public int MedicineId { get; set; }
    
    public Medicine Medicine { get; set; }
        
    [Required]
    [Range(1,1000,ErrorMessage = "Quantity Must be At least 1.")]
    public int Quantity { get; set; }
    
    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal UnitPrice { get; set; }
}