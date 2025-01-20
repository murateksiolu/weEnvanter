using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using weEnvanter.Data.Repositories.Interfaces;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(WeEnvanterDbContext context) : base(context)
        {
        }

        public async Task<User> GetByUsernameAsync(string username)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Username == username && !x.IsDeleted);
        }

        public async Task<bool> IsUsernameUniqueAsync(string username)
        {
            return !await _dbSet.AnyAsync(x => x.Username == username && !x.IsDeleted);
        }
    }
} 