using Microsoft.EntityFrameworkCore;
using PharmacyApi.Models;

namespace PharmacyApi.Data;

public class PharmacyDbContext : DbContext
{
    public PharmacyDbContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Medicine>().Property(m => m.Price).HasColumnType("decimal(18,2)");
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Medicine> Medicines { get; set; }
    
    public DbSet<Supplier> Suppliers { get; set; }
    
    public DbSet<Customer> Customers { get; set; }
}