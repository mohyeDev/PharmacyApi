using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyApi.Models;

public class Sale
{
    public int Id { get; set; }

    [ForeignKey("Customer")]
    public int CustomerId { get; set; }
    
    public Customer Customer { get; set; }
    
    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalAmount { get; set; }

    public List<SaleItem> SaleItems { get; set; } = new();
}