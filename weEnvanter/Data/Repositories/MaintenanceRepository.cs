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
    public class MaintenanceRepository : BaseRepository<Maintenance>, IMaintenanceRepository
    {
        public MaintenanceRepository(WeEnvanterDbContext context) : base(context)
        {
        }

        public async Task<List<Maintenance>> GetByInventoryIdAsync(int inventoryId)
        {
            return await _dbSet.Where(x => x.InventoryId == inventoryId && !x.IsDeleted)
                .OrderByDescending(x => x.StartDate)
                .ToListAsync();
        }

        public async Task<Maintenance> GetActiveMaintenanceByInventoryIdAsync(int inventoryId)
        {
            return await _dbSet.FirstOrDefaultAsync(x => 
                x.InventoryId == inventoryId && 
                x.Status == MaintenanceStatus.InProgress && 
                !x.IsDeleted);
        }

        public async Task<List<Maintenance>> GetByStatusAsync(MaintenanceStatus status)
        {
            return await _dbSet.Where(x => x.Status == status && !x.IsDeleted)
                .OrderByDescending(x => x.StartDate)
                .ToListAsync();
        }

        public async Task<List<Maintenance>> GetPendingMaintenanceAsync()
        {
            return await _dbSet.Where(x => x.Status == MaintenanceStatus.InProgress && !x.IsDeleted)
                .OrderBy(x => x.StartDate)
                .ToListAsync();
        }

        public async Task<int> GetUpcomingMaintenanceCountAsync(int days)
        {
            var targetDate = DateTime.Now.AddDays(days);
            return await _dbSet.CountAsync(x => x.Status == MaintenanceStatus.InProgress && 
                                               x.StartDate <= targetDate && 
                                               x.StartDate > DateTime.Now);
        }

        public async Task<List<Maintenance>> GetUpcomingMaintenancesAsync(int days)
        {
            var targetDate = DateTime.Now.AddDays(days);
            return await _dbSet.Where(x => x.Status == MaintenanceStatus.InProgress && 
                                         x.StartDate <= targetDate && 
                                         x.StartDate > DateTime.Now)
                              .OrderBy(x => x.StartDate)
                              .ToListAsync();
        }
    }
} 