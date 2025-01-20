using System.Collections.Generic;
using System.Threading.Tasks;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Data.Repositories.Interfaces
{
    public interface IInventoryCategoryRepository : IBaseRepository<InventoryCategory>
    {
        Task<List<InventoryCategory>> GetActiveAsync();
        Task<InventoryCategory> GetByCodeAsync(string categoryCode);
        Task<List<InventoryCategory>> GetByParentCategoryAsync(int? parentCategoryId);
        Task<bool> HasInventoriesAsync(int categoryId);
        Task<bool> IsCategoryCodeUniqueAsync(string categoryCode);
    }
} 