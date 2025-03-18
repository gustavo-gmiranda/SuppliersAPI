using Microsoft.EntityFrameworkCore;
using SuppliersAPI.Data;

namespace SuppliersAPI.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly SuppliersDbContext _context;

        public SupplierRepository(SuppliersDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SuppliersAPI.Models.Supplier>> GetAllAsync()
        {
            return await _context.Suppliers.ToListAsync();
        }

        public async Task<SuppliersAPI.Models.Supplier> GetByIdAsync(int id)
        {
            return await _context.Suppliers.FindAsync(id);
        }

        public async Task AddAsync(SuppliersAPI.Models.Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(SuppliersAPI.Models.Supplier supplier)
        {
            _context.Entry(supplier).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var supplier = await _context.Suppliers.FindAsync(id);
            if (supplier != null)
            {
                _context.Suppliers.Remove(supplier);
                await _context.SaveChangesAsync();
            }
        }
    }
}
