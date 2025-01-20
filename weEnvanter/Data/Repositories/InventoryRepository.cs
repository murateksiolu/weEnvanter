using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using weEnvanter.Data.Repositories.Interfaces;
using weEnvanter.Domain.Entities;
using weEnvanter.Domain.Enums;

namespace weEnvanter.Data.Repositories
{
    public class InventoryRepository : BaseRepository<Inventory>, IInventoryRepository
    {
        public InventoryRepository(WeEnvanterDbContext context) : base(context)
        {
        }

        public async Task<List<Inventory>> GetByDepartmentAsync(int departmentId)
        {
            return await _dbSet.Where(x => x.DepartmentId == departmentId && !x.IsDeleted)
                .OrderBy(x => x.Name)
                .ToListAsync();
        }

        public async Task<List<Inventory>> GetByEmployeeAsync(int employeeId)
        {
            return await _dbSet.Where(x => x.AssignedEmployeeId == employeeId && !x.IsDeleted)
                .OrderBy(x => x.Name)
                .ToListAsync();
        }

        public async Task<List<Inventory>> GetByCategoryAsync(int inventoryCategoryId)
        {
            return await _dbSet.Where(x => x.InventoryCategoryId == inventoryCategoryId && !x.IsDeleted)
                .OrderBy(x => x.Name)
                .ToListAsync();
        }

        public async Task<List<Inventory>> GetByStatusAsync(InventoryStatus status)
        {
            return await _dbSet.Where(x => x.Status == status && !x.IsDeleted)
                .OrderBy(x => x.Name)
                .ToListAsync();
        }

        public async Task<List<Inventory>> GetExpiredWarrantyItemsAsync()
        {
            var today = DateTime.Now.Date;
            return await _dbSet.Where(x => x.WarrantyEndDate < today && !x.IsDeleted)
                .OrderBy(x => x.WarrantyEndDate)
                .ToListAsync();
        }

        public async Task<List<Inventory>> GetMaintenanceDueItemsAsync()
        {
            var today = DateTime.Now.Date;
            return await _dbSet.Where(x => 
                x.NextMaintenanceDate <= today && 
                x.Status != InventoryStatus.InMaintenance && 
                !x.IsDeleted)
                .OrderBy(x => x.NextMaintenanceDate)
                .ToListAsync();
        }

        public async Task<Inventory> GetByInventoryCodeAsync(string inventoryCode)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.InventoryCode == inventoryCode && !x.IsDeleted);
        }
    }
} 