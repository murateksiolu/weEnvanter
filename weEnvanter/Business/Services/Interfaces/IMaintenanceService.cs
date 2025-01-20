using System.Collections.Generic;
using System.Threading.Tasks;
using weEnvanter.Domain.Entities;
using weEnvanter.Domain.Enums;

namespace weEnvanter.Business.Services.Interfaces
{
    public interface IMaintenanceService : IBaseService<Maintenance>
    {
        Task<List<Maintenance>> GetByInventoryIdAsync(int inventoryId);
        Task<Maintenance> GetActiveMaintenanceByInventoryIdAsync(int inventoryId);
        Task<List<Maintenance>> GetByStatusAsync(MaintenanceStatus status);
        Task<List<Maintenance>> GetPendingMaintenanceAsync();
        Task<bool> StartMaintenanceAsync(int inventoryId, string description);
        Task<bool> CompleteMaintenanceAsync(int maintenanceId, string notes);
        Task<bool> CancelMaintenanceAsync(int maintenanceId, string reason);
        Task<bool> CanBeDeletedAsync(int maintenanceId);
        Task<bool> CanBeCompletedAsync(int maintenanceId);
        Task<bool> CanBeCanceledAsync(int maintenanceId);

        // Dashboard için eklenen metodlar
        int GetUpcomingMaintenanceCount(int days);
        List<Maintenance> GetUpcomingMaintenances(int days);
    }
} 