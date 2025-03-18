namespace SuppliersAPI.Repositories
{
    public interface ISupplierRepository
    {
        Task<IEnumerable<SuppliersAPI.Models.Supplier>> GetAllAsync();
        Task<SuppliersAPI.Models.Supplier> GetByIdAsync(int id);
        Task AddAsync(SuppliersAPI.Models.Supplier supplier);
        Task UpdateAsync(SuppliersAPI.Models.Supplier supplier);
        Task DeleteAsync(int id);
    }
}
