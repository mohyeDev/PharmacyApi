using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyApi.Models;

public class SaleItem
{
    
    public int Id { get; set; }
    
    [ForeignKey("Sale")]
    public int SaleId { get; set; }
    
    public Sale Sale { get; set; }
    
    [Required]
    [ForeignKey("Medicine")]
    public int MedicineId { get; set; }
    
    public Medicine Medicine { get; set; }
    
    [Required]
    [Range(1,1000,ErrorMessage = "Quantity Must Be At Least 1 .")]
    public int Quantity { get; set; }
    
    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal UnitPrice { get; set; }
}