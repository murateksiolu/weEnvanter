using System.Collections.Generic;
using System.Threading.Tasks;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Business.Services.Interfaces
{
    public interface IInventoryCategoryService : IBaseService<InventoryCategory>
    {
        Task<List<InventoryCategory>> GetByParentCategoryAsync(int? parentCategoryId);
        Task<bool> HasInventoriesAsync(int categoryId);
        Task<bool> IsCategoryCodeUniqueAsync(string categoryCode);
        Task<InventoryCategory> GetByCategoryCodeAsync(string categoryCode);
        Task<bool> CanBeDeletedAsync(int categoryId);
    }
} 