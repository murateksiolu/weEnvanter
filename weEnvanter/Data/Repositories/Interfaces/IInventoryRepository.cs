using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using weEnvanter.Domain.Entities;
using weEnvanter.Domain.Enums;

namespace weEnvanter.Data.Repositories.Interfaces
{
    public interface IInventoryRepository : IBaseRepository<Inventory>
    {
        Task<List<Inventory>> GetByDepartmentAsync(int departmentId);
        Task<List<Inventory>> GetByEmployeeAsync(int employeeId);
        Task<List<Inventory>> GetByCategoryAsync(int inventoryCategoryId);
        Task<List<Inventory>> GetByStatusAsync(InventoryStatus status);
        Task<List<Inventory>> GetExpiredWarrantyItemsAsync();
        Task<List<Inventory>> GetMaintenanceDueItemsAsync();
        Task<Inventory> GetByInventoryCodeAsync(string inventoryCode);
        Task<int> GetActiveInventoryCountAsync();
        Task<int> GetAssignedInventoryCountAsync();
        Task<int> GetUpcomingExpirationCountAsync(int days);
        Task<int> GetUpcomingCalibrationCountAsync(int days);
        Task<List<Inventory>> GetUpcomingCalibrationsAsync(int days);
        Task<List<Inventory>> GetUpcomingExpirationsAsync(int days);
        Task<List<Inventory>> GetLastAddedInventoriesAsync(int count);
        Task<List<Inventory>> GetLastAssignedInventoriesAsync(int count);
    }
} 