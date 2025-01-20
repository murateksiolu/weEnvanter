using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Data.Repositories.Interfaces;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Business.Services
{
    public class InventoryCategoryService : BaseService<InventoryCategory>, IInventoryCategoryService
    {
        private readonly IInventoryCategoryRepository _inventoryCategoryRepository;
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryCategoryService(
            IInventoryCategoryRepository inventoryCategoryRepository,
            IInventoryRepository inventoryRepository) : base(inventoryCategoryRepository)
        {
            _inventoryCategoryRepository = inventoryCategoryRepository;
            _inventoryRepository = inventoryRepository;
        }

        public override async Task<InventoryCategory> AddAsync(InventoryCategory category)
        {
            if (string.IsNullOrEmpty(category.Name))
                throw new ArgumentException("Kategori adı boş olamaz.");

            if (string.IsNullOrEmpty(category.CategoryCode))
                throw new ArgumentException("Kategori kodu boş olamaz.");

            var existingCategory = await _inventoryCategoryRepository.GetByCodeAsync(category.CategoryCode);
            if (existingCategory != null)
                throw new InvalidOperationException("Bu kategori kodu zaten kullanılıyor.");

            category.CreatedDate = DateTime.Now;
            category.IsActive = true;

            return await base.AddAsync(category);
        }

        public override async Task<InventoryCategory> UpdateAsync(InventoryCategory category)
        {
            var existingCategory = await GetByIdAsync(category.Id);
            if (existingCategory == null)
                throw new ArgumentException("Güncellenecek kategori bulunamadı.");

            if (category.CategoryCode != existingCategory.CategoryCode)
            {
                var categoryWithSameCode = await _inventoryCategoryRepository.GetByCodeAsync(category.CategoryCode);
                if (categoryWithSameCode != null)
                    throw new InvalidOperationException("Bu kategori kodu başka bir kategori tarafından kullanılıyor.");
            }

            category.ModifiedDate = DateTime.Now;
            return await base.UpdateAsync(category);
        }

        public override async Task<bool> DeleteAsync(int id)
        {
            var category = await GetByIdAsync(id);
            if (category == null)
                throw new ArgumentException("Silinecek kategori bulunamadı.");

            var inventories = await _inventoryRepository.GetByCategoryAsync(id);
            if (inventories.Count > 0)
                throw new InvalidOperationException("Demirbaşı olan kategori silinemez.");

            return await base.DeleteAsync(id);
        }

        public async Task<List<InventoryCategory>> GetActiveAsync()
        {
            return await _inventoryCategoryRepository.GetActiveAsync();
        }

        public async Task<InventoryCategory> GetByCodeAsync(string categoryCode)
        {
            return await _inventoryCategoryRepository.GetByCodeAsync(categoryCode);
        }

        public async Task<bool> DeactivateCategoryAsync(int categoryId)
        {
            var category = await GetByIdAsync(categoryId);
            if (category == null)
                throw new ArgumentException("Kategori bulunamadı.");

            if (!category.IsActive)
                throw new InvalidOperationException("Kategori zaten pasif durumda.");

            var inventories = await _inventoryRepository.GetByCategoryAsync(categoryId);
            if (inventories.Count > 0)
                throw new InvalidOperationException("Demirbaşı olan kategori pasife alınamaz.");

            category.IsActive = false;
            category.ModifiedDate = DateTime.Now;

            await UpdateAsync(category);
            return true;
        }

        public async Task<bool> ActivateCategoryAsync(int categoryId)
        {
            var category = await GetByIdAsync(categoryId);
            if (category == null)
                throw new ArgumentException("Kategori bulunamadı.");

            if (category.IsActive)
                throw new InvalidOperationException("Kategori zaten aktif durumda.");

            category.IsActive = true;
            category.ModifiedDate = DateTime.Now;

            await UpdateAsync(category);
            return true;
        }

        public async Task<List<Inventory>> GetCategoryInventoriesAsync(int categoryId)
        {
            return await _inventoryRepository.GetByCategoryAsync(categoryId);
        }

        public async Task<List<InventoryCategory>> GetByParentCategoryAsync(int? parentCategoryId)
        {
            return await _inventoryCategoryRepository.GetByParentCategoryAsync(parentCategoryId);
        }

        public async Task<bool> HasInventoriesAsync(int categoryId)
        {
            return await _inventoryCategoryRepository.HasInventoriesAsync(categoryId);
        }

        public async Task<bool> IsCategoryCodeUniqueAsync(string categoryCode)
        {
            return await _inventoryCategoryRepository.IsCategoryCodeUniqueAsync(categoryCode);
        }

        public async Task<InventoryCategory> GetByCategoryCodeAsync(string categoryCode)
        {
            return await _inventoryCategoryRepository.GetByCodeAsync(categoryCode);
        }

        public async Task<bool> CanBeDeletedAsync(int categoryId)
        {
            var category = await GetByIdAsync(categoryId);
            if (category == null)
                return false;

            // Alt kategorileri var mı?
            var subCategories = await GetByParentCategoryAsync(categoryId);
            if (subCategories.Count > 0)
                return false;

            // Demirbaşları var mı?
            var hasInventories = await HasInventoriesAsync(categoryId);
            if (hasInventories)
                return false;

            return true;
        }
    }
} 