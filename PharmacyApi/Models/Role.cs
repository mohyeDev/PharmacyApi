using System.ComponentModel.DataAnnotations;

namespace PharmacyApi.Models;

public class Role
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Role Name is Required")]
    [StringLength(50,ErrorMessage = "Role name must be up to 50 characters long.")]
    public string Name { get; set; }
    
    public List<User> Users { get; set; }
}