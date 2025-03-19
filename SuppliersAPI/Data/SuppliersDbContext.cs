using Microsoft.EntityFrameworkCore;
using SuppliersAPI.Models;

namespace SuppliersAPI.Data
{
    public class SuppliersDbContext : DbContext
    {
        public SuppliersDbContext(DbContextOptions<SuppliersDbContext> options) : base(options) { }

        public DbSet<SuppliersAPI.Models.Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
