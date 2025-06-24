using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyApi.Models;

public class Purchase
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Purchase date is required.")]
    public DateTime PurchaseDate { get; set; } = DateTime.UtcNow;

    [Required(ErrorMessage = "Supplier ID is required.")]
    [ForeignKey("Supplier")]
    public int SupplierId { get; set; }

    public Supplier Supplier { get; set; } = null!;

    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalAmount { get; set; }
    

    public List<PurchaseItem> PurchaseItems { get; set; } = new();
}