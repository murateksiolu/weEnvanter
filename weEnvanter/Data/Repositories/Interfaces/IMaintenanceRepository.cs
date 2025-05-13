using System.Collections.Generic;
using System.Threading.Tasks;
using weEnvanter.Domain.Entities;
using weEnvanter.Domain.Enums;

namespace weEnvanter.Data.Repositories.Interfaces
{
    public interface IMaintenanceRepository : IBaseRepository<Maintenance>
    {
        Task<List<Maintenance>> GetByInventoryIdAsync(int inventoryId);
        Task<Maintenance> GetActiveMaintenanceByInventoryIdAsync(int inventoryId);
        Task<List<Maintenance>> GetByStatusAsync(MaintenanceStatus status);
        Task<List<Maintenance>> GetPendingMaintenanceAsync();
        Task<int> GetUpcomingMaintenanceCountAsync(int days);
        Task<List<Maintenance>> GetUpcomingMaintenancesAsync(int days);
    }
} 