using Microsoft.EntityFrameworkCore;

namespace SuppliersAPI.Data
{
    public class SuppliersDbContext : DbContext
    {
        public SuppliersDbContext(DbContextOptions<SuppliersDbContext> options) : base(options) { }

        public DbSet<SuppliersAPI.Models.Supplier> Suppliers { get; set; }
    }
}
