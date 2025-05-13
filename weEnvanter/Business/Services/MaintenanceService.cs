using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Data.Repositories.Interfaces;
using weEnvanter.Domain.Entities;
using weEnvanter.Domain.Enums;

namespace weEnvanter.Business.Services
{
    public class MaintenanceService : BaseService<Maintenance>, IMaintenanceService
    {
        private readonly IMaintenanceRepository _maintenanceRepository;
        private readonly IInventoryRepository _inventoryRepository;

        public MaintenanceService(
            IMaintenanceRepository maintenanceRepository,
            IInventoryRepository inventoryRepository) : base(maintenanceRepository)
        {
            _maintenanceRepository = maintenanceRepository;
            _inventoryRepository = inventoryRepository;
        }

        public override async Task<Maintenance> AddAsync(Maintenance maintenance)
        {
            if (maintenance.InventoryId <= 0)
                throw new ArgumentException("Geçersiz demirbaş ID.");

            if (string.IsNullOrEmpty(maintenance.Description))
                throw new ArgumentException("Bakım açıklaması boş olamaz.");

            var inventory = await _inventoryRepository.GetByIdAsync(maintenance.InventoryId);
            if (inventory == null)
                throw new ArgumentException("Demirbaş bulunamadı.");

            var activeMaintenance = await _maintenanceRepository.GetActiveMaintenanceByInventoryIdAsync(maintenance.InventoryId);
            if (activeMaintenance != null)
                throw new InvalidOperationException("Bu demirbaşın aktif bir bakım kaydı zaten var.");

            maintenance.StartDate = DateTime.Now;
            maintenance.Status = MaintenanceStatus.InProgress;
            maintenance.CreatedDate = DateTime.Now;

            return await base.AddAsync(maintenance);
        }

        public async Task<List<Maintenance>> GetByInventoryIdAsync(int inventoryId)
        {
            return await _maintenanceRepository.GetByInventoryIdAsync(inventoryId);
        }

        public async Task<Maintenance> GetActiveMaintenanceByInventoryIdAsync(int inventoryId)
        {
            return await _maintenanceRepository.GetActiveMaintenanceByInventoryIdAsync(inventoryId);
        }

        public async Task<List<Maintenance>> GetByStatusAsync(MaintenanceStatus status)
        {
            return await _maintenanceRepository.GetByStatusAsync(status);
        }

        public async Task<List<Maintenance>> GetPendingMaintenanceAsync()
        {
            return await _maintenanceRepository.GetPendingMaintenanceAsync();
        }

        public async Task<bool> StartMaintenanceAsync(int inventoryId, string description)
        {
            var inventory = await _inventoryRepository.GetByIdAsync(inventoryId);
            if (inventory == null)
                throw new ArgumentException("Demirbaş bulunamadı.");

            var activeMaintenance = await _maintenanceRepository.GetActiveMaintenanceByInventoryIdAsync(inventoryId);
            if (activeMaintenance != null)
                throw new InvalidOperationException("Bu demirbaşın aktif bir bakım kaydı zaten var.");

            var maintenance = new Maintenance
            {
                InventoryId = inventoryId,
                Description = description,
                StartDate = DateTime.Now,
                Status = MaintenanceStatus.InProgress,
                CreatedDate = DateTime.Now
            };

            await AddAsync(maintenance);

            inventory.Status = InventoryStatus.InMaintenance;
            await _inventoryRepository.UpdateAsync(inventory);

            return true;
        }

        public async Task<bool> CompleteMaintenanceAsync(int maintenanceId, string notes)
        {
            var maintenance = await GetByIdAsync(maintenanceId);
            if (maintenance == null)
                throw new ArgumentException("Bakım kaydı bulunamadı.");

            if (maintenance.Status != MaintenanceStatus.InProgress)
                throw new InvalidOperationException("Bu bakım kaydı tamamlanamaz.");

            maintenance.EndDate = DateTime.Now;
            maintenance.Notes = notes;
            maintenance.Status = MaintenanceStatus.Completed;
            maintenance.ModifiedDate = DateTime.Now;

            await UpdateAsync(maintenance);

            var inventory = await _inventoryRepository.GetByIdAsync(maintenance.InventoryId);
            if (inventory != null)
            {
                inventory.Status = InventoryStatus.Active;
                inventory.LastMaintenanceDate = DateTime.Now;
                await _inventoryRepository.UpdateAsync(inventory);
            }

            return true;
        }

        public async Task<bool> CancelMaintenanceAsync(int maintenanceId, string reason)
        {
            var maintenance = await GetByIdAsync(maintenanceId);
            if (maintenance == null)
                throw new ArgumentException("Bakım kaydı bulunamadı.");

            if (maintenance.Status != MaintenanceStatus.InProgress)
                throw new InvalidOperationException("Bu bakım kaydı iptal edilemez.");

            maintenance.EndDate = DateTime.Now;
            maintenance.Notes = reason;
            maintenance.Status = MaintenanceStatus.Cancelled;
            maintenance.ModifiedDate = DateTime.Now;

            await UpdateAsync(maintenance);

            var inventory = await _inventoryRepository.GetByIdAsync(maintenance.InventoryId);
            if (inventory != null)
            {
                inventory.Status = InventoryStatus.Active;
                await _inventoryRepository.UpdateAsync(inventory);
            }

            return true;
        }

        public async Task<bool> CanBeDeletedAsync(int maintenanceId)
        {
            var maintenance = await GetByIdAsync(maintenanceId);
            if (maintenance == null)
                return false;

            // Tamamlanmış veya iptal edilmiş bakımlar silinebilir
            if (maintenance.Status != MaintenanceStatus.Completed && 
                maintenance.Status != MaintenanceStatus.Cancelled)
                return false;

            return true;
        }

        public async Task<bool> CanBeCompletedAsync(int maintenanceId)
        {
            var maintenance = await GetByIdAsync(maintenanceId);
            if (maintenance == null)
                return false;

            // Sadece devam eden bakımlar tamamlanabilir
            if (maintenance.Status != MaintenanceStatus.InProgress)
                return false;

            return true;
        }

        public async Task<bool> CanBeCanceledAsync(int maintenanceId)
        {
            var maintenance = await GetByIdAsync(maintenanceId);
            if (maintenance == null)
                return false;

            // Sadece bekleyen veya devam eden bakımlar iptal edilebilir
            if (maintenance.Status != MaintenanceStatus.Pending && 
                maintenance.Status != MaintenanceStatus.InProgress)
                return false;

            return true;
        }

        // Dashboard için eklenen metodlar
        public async Task<int> GetUpcomingMaintenanceCountAsync(int days)
        {
            return await _maintenanceRepository.GetUpcomingMaintenanceCountAsync(days);
        }

        public async Task<List<Maintenance>> GetUpcomingMaintenancesAsync(int days)
        {
            return await _maintenanceRepository.GetUpcomingMaintenancesAsync(days);
        }
    }
} 