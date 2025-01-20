using System.Threading.Tasks;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Data.Repositories.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> GetByUsernameAsync(string username);
        Task<bool> IsUsernameUniqueAsync(string username);
    }
} 