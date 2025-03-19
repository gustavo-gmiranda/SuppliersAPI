using Microsoft.EntityFrameworkCore;
using SuppliersAPI.Data;
using SuppliersAPI.Models;
using System.Threading.Tasks;

namespace SuppliersAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SuppliersDbContext _context;

        public UserRepository(SuppliersDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
        }
    }
}