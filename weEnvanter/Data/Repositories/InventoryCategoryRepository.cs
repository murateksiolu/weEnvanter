using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using weEnvanter.Data.Repositories.Interfaces;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Data.Repositories
{
    public class InventoryCategoryRepository : BaseRepository<InventoryCategory>, IInventoryCategoryRepository
    {
        public InventoryCategoryRepository(WeEnvanterDbContext context) : base(context)
        {
        }

        public async Task<List<InventoryCategory>> GetActiveAsync()
        {
            return await _dbSet.Where(x => x.IsActive && !x.IsDeleted)
                .OrderBy(x => x.Name)
                .ToListAsync();
        }

        public async Task<InventoryCategory> GetByCodeAsync(string categoryCode)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.CategoryCode == categoryCode && !x.IsDeleted);
        }

        public async Task<List<InventoryCategory>> GetByParentCategoryAsync(int? parentCategoryId)
        {
            return await _dbSet.Where(x => x.ParentCategoryId == parentCategoryId && !x.IsDeleted)
                .OrderBy(x => x.Name)
                .ToListAsync();
        }

        public async Task<bool> HasInventoriesAsync(int categoryId)
        {
            return await _context.Inventories.AnyAsync(x => x.InventoryCategoryId == categoryId && !x.IsDeleted);
        }

        public async Task<bool> IsCategoryCodeUniqueAsync(string categoryCode)
        {
            return !await _dbSet.AnyAsync(x => x.CategoryCode == categoryCode && !x.IsDeleted);
        }
    }
} 