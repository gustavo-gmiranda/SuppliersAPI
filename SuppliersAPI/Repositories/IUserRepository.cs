using SuppliersAPI.Models;
using System.Threading.Tasks;

namespace SuppliersAPI.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUserByUsernameAsync(string username);
    }
}