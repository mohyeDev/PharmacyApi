using Microsoft.EntityFrameworkCore;
using PharmacyApi.Models;

namespace PharmacyApi.Data;

public class PharmacyDbContext : DbContext
{
    public PharmacyDbContext(DbContextOptions options) : base(options)
    {
        
    }

    

    public DbSet<Medicine> Medicines { get; set; }
    
    public DbSet<Supplier> Suppliers { get; set; }
    
    public DbSet<Customer> Customers { get; set; }
    
    public DbSet<Purchase> Purchases { get; set; }
    public DbSet<PurchaseItem> PurchaseItems { get; set; }
    
    public DbSet<Sale>Sales { get; set; }
    
    public DbSet<SaleItem> SaleItems { get; set; }
    
    public DbSet<Inventory> Inventories { get; set; }
    
    public DbSet<Role> Roles { get; set; }
    
    public DbSet<User> Users { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Medicine>().Property(m => m.Price).HasColumnType("decimal(18,2)");
        base.OnModelCreating(modelBuilder);
            
        modelBuilder.Entity<Role>().HasIndex(r => r.Name).IsUnique();
        modelBuilder.Entity<User>().HasOne(u => u.Role).WithMany(r => r.Users).HasForeignKey(u => u.RoleId);
        modelBuilder.Entity<Purchase>().HasOne(p => p.Supplier).WithMany(s => s.Purchases)
            .HasForeignKey(p => p.SupplierId).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Sale>().HasOne(s => s.Customer).WithMany(c => c.Sales).HasForeignKey(s => s.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<PurchaseItem>().HasOne(pi => pi.Purchase).WithMany(p => p.PurchaseItems)
            .HasForeignKey(pi => pi.PurchaseId).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<PurchaseItem>().HasOne(pi => pi.Medicine).WithMany().HasForeignKey(pi => pi.MedicineId)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<SaleItem>().HasOne(si => si.Sale).WithMany(s => s.SaleItems).HasForeignKey(si => si.SaleId).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<SaleItem>().HasOne(si => si.Medicine).WithMany().HasForeignKey(si => si.MedicineId)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Inventory>().HasOne(i => i.Medicine).WithOne().HasForeignKey<Inventory>(i => i.MedicineId)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Inventory>().HasIndex(i => i.MedicineId).IsUnique();
        modelBuilder.Entity<User>().HasIndex(u => u.UserName).IsUnique();
        modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();



    }
}