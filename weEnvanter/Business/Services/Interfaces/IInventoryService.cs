using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using weEnvanter.Domain.Entities;
using weEnvanter.Domain.Enums;

namespace weEnvanter.Business.Services.Interfaces
{
    public interface IInventoryService : IBaseService<Inventory>
    {
        // Özel sorgular
        Inventory GetById(int id);
        Task<List<Inventory>> GetByDepartmentAsync(int departmentId);
        Task<List<Inventory>> GetByEmployeeAsync(int employeeId);
        Task<List<Inventory>> GetByCategoryAsync(int inventoryCategoryId);
        Task<List<Inventory>> GetByStatusAsync(InventoryStatus status);
        
        // Zimmet işlemleri
        Task<bool> AssignToEmployeeAsync(int inventoryId, int employeeId, string notes = null);
        Task<bool> UnassignFromEmployeeAsync(int inventoryId, string notes = null);
        Task<InventoryAssignment> AddAssignmentAsync(InventoryAssignment assignment);
        
        // Bakım işlemleri
        Task<bool> SendToMaintenanceAsync(int inventoryId, string description);
        Task<bool> CompleteMaintenanceAsync(int inventoryId, string notes);
        
        // Raporlama işlemleri
        Task<List<Inventory>> GetExpiredWarrantyItemsAsync();
        Task<List<Inventory>> GetMaintenanceDueItemsAsync();
        Task<decimal> GetTotalInventoryValueAsync();
        Task<Inventory> GetByInventoryCodeAsync(string inventoryCode);
        Task<bool> IsInventoryCodeUniqueAsync(string inventoryCode);
        Task<bool> CanBeDeletedAsync(int inventoryId);
        Task<bool> CanBeAssignedAsync(int inventoryId);
        Task<bool> CanBeMaintenancedAsync(int inventoryId);

        // Dashboard için eklenen metodlar
        Task<int> GetActiveInventoryCountAsync();
        Task<int> GetUpcomingExpirationCountAsync(int days);
        Task<int> GetUpcomingCalibrationCountAsync(int days);
        Task<int> GetAssignedInventoryCountAsync();
        Task<List<Inventory>> GetUpcomingCalibrationsAsync(int days);
        Task<List<Inventory>> GetUpcomingExpirationsAsync(int days);
        Task<List<Inventory>> GetLastAddedInventoriesAsync(int count);
        Task<List<Inventory>> GetLastAssignedInventoriesAsync(int count);
    }
} 