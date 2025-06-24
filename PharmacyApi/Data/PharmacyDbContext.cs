using Microsoft.EntityFrameworkCore;

namespace PharmacyApi.Data;

public class PharmacyDbContext : DbContext
{
    public PharmacyDbContext(DbContextOptions options) : base(options)
    {
        
    }
}