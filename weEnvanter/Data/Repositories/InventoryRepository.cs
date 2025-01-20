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
            return await _dbSet.Where(x => x.WarrantyExpirationDate < today && !x.IsDeleted)
                .OrderBy(x => x.WarrantyExpirationDate)
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

        public async Task<int> GetActiveInventoryCountAsync()
        {
            return await _dbSet.CountAsync(x => x.IsActive && !x.IsDeleted && x.Status != InventoryStatus.Disposed);
        }

        public async Task<int> GetAssignedInventoryCountAsync()
        {
            return await _dbSet.CountAsync(x => x.IsActive && !x.IsDeleted && x.AssignedEmployeeId.HasValue);
        }

        public async Task<int> GetUpcomingExpirationCountAsync(int days)
        {
            var targetDate = DateTime.Now.AddDays(days);
            return await _dbSet.CountAsync(x => x.IsActive && !x.IsDeleted && 
                x.WarrantyExpirationDate.HasValue && 
                x.WarrantyExpirationDate.Value <= targetDate && 
                x.WarrantyExpirationDate.Value > DateTime.Now);
        }

        public async Task<int> GetUpcomingCalibrationCountAsync(int days)
        {
            var targetDate = DateTime.Now.AddDays(days);
            return await _dbSet.CountAsync(x => x.IsActive && !x.IsDeleted && 
                x.CalibrationDueDate.HasValue && 
                x.CalibrationDueDate.Value <= targetDate && 
                x.CalibrationDueDate.Value > DateTime.Now);
        }

        public async Task<List<Inventory>> GetUpcomingCalibrationsAsync(int days)
        {
            var targetDate = DateTime.Now.AddDays(days);
            return await _dbSet.Where(x => x.IsActive && !x.IsDeleted && 
                x.CalibrationDueDate.HasValue && 
                x.CalibrationDueDate.Value <= targetDate && 
                x.CalibrationDueDate.Value > DateTime.Now)
                .OrderBy(x => x.CalibrationDueDate)
                .ToListAsync();
        }

        public async Task<List<Inventory>> GetUpcomingExpirationsAsync(int days)
        {
            var targetDate = DateTime.Now.AddDays(days);
            return await _dbSet.Where(x => x.IsActive && !x.IsDeleted && 
                x.WarrantyExpirationDate.HasValue && 
                x.WarrantyExpirationDate.Value <= targetDate && 
                x.WarrantyExpirationDate.Value > DateTime.Now)
                .OrderBy(x => x.WarrantyExpirationDate)
                .ToListAsync();
        }

        public async Task<List<Inventory>> GetLastAddedInventoriesAsync(int count)
        {
            return await _dbSet.Where(x => x.IsActive && !x.IsDeleted)
                .OrderByDescending(x => x.CreatedDate)
                .Take(count)
                .ToListAsync();
        }

        public async Task<List<Inventory>> GetLastAssignedInventoriesAsync(int count)
        {
            return await _dbSet.Where(x => x.IsActive && !x.IsDeleted && x.AssignedEmployeeId.HasValue)
                .OrderByDescending(x => x.ModifiedDate)
                .Take(count)
                .ToListAsync();
        }
    }
} 