using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyApi.Models;

public class User
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Username is required.")]
    [StringLength(50, ErrorMessage = "Username must be up to 50 characters long.")]
    public string UserName { get; set; }
    [Required(ErrorMessage = "Password hash is required.")]
    public string PasswordHash { get; set; }
    
    
    [Required(ErrorMessage = "Email is Required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    [StringLength(100, ErrorMessage = "Email must be up to 100 characters long.")]
    public string Email { get; set; }
    
    [ForeignKey("Role")]
    public int RoleId { get; set; }
    
    public Role Role { get; set; }
    
    public DateTime RegistrationDate { get; set; } = DateTime.Now;
}