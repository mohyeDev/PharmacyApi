using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyApi.Models;

public class Inventory
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Medicine Id Is Required")]
    [ForeignKey("Medicine")]
    public int MedicineId { get; set; }
    
    public Medicine Medicine { get; set; }
    
    
    [Required(ErrorMessage = "Quantity Is Required")]
    [Range(0,999,ErrorMessage = "Quantity Cannot Be Negative")]
    public  int Quantity { get; set; }

    public DateTime LastUpdate { get; set; } = DateTime.Now; 
}