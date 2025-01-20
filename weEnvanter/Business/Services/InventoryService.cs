using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Data.Repositories.Interfaces;
using weEnvanter.Domain.Entities;
using weEnvanter.Domain.Enums;

namespace weEnvanter.Business.Services
{
    public class InventoryService : BaseService<Inventory>, IInventoryService
    {
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMaintenanceRepository _maintenanceRepository;

        public InventoryService(
            IInventoryRepository inventoryRepository,
            IEmployeeRepository employeeRepository,
            IMaintenanceRepository maintenanceRepository) : base(inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
            _employeeRepository = employeeRepository;
            _maintenanceRepository = maintenanceRepository;
        }

        public override async Task<Inventory> AddAsync(Inventory inventory)
        {
            // Validasyon kontrolleri
            if (string.IsNullOrEmpty(inventory.Name))
                throw new ArgumentException("Demirbaş adı boş olamaz.");

            if (string.IsNullOrEmpty(inventory.InventoryCode))
                throw new ArgumentException("Demirbaş kodu boş olamaz.");

            inventory.CreatedDate = DateTime.Now;
            inventory.Status = InventoryStatus.Active;

            return await base.AddAsync(inventory);
        }

        public override async Task<Inventory> UpdateAsync(Inventory inventory)
        {
            var existingInventory = await GetByIdAsync(inventory.Id);
            if (existingInventory == null)
                throw new ArgumentException("Güncellenecek demirbaş bulunamadı.");

            inventory.ModifiedDate = DateTime.Now;
            return await base.UpdateAsync(inventory);
        }

        public override async Task<bool> DeleteAsync(int id)
        {
            var inventory = await GetByIdAsync(id);
            if (inventory == null)
                throw new ArgumentException("Silinecek demirbaş bulunamadı.");

            // Zimmetli demirbaş kontrolü
            if (!string.IsNullOrEmpty(inventory.AssignedEmployeeId.ToString()) && inventory.AssignedEmployeeId > 0)
                throw new InvalidOperationException("Zimmetli demirbaş silinemez. Önce zimmetten düşürün.");

            return await base.DeleteAsync(id);
        }

        public async Task<List<Inventory>> GetByDepartmentAsync(int departmentId)
        {
            return await _inventoryRepository.GetByDepartmentAsync(departmentId);
        }

        public async Task<List<Inventory>> GetByEmployeeAsync(int employeeId)
        {
            return await _inventoryRepository.GetByEmployeeAsync(employeeId);
        }

        public async Task<List<Inventory>> GetByCategoryAsync(int categoryId)
        {
            return await _inventoryRepository.GetByCategoryAsync(categoryId);
        }

        public async Task<List<Inventory>> GetByStatusAsync(InventoryStatus status)
        {
            return await _inventoryRepository.GetByStatusAsync(status);
        }

        public async Task<bool> AssignToEmployeeAsync(int inventoryId, int employeeId, string notes = null)
        {
            var inventory = await GetByIdAsync(inventoryId);
            if (inventory == null)
                throw new ArgumentException("Demirbaş bulunamadı.");

            var employee = await _employeeRepository.GetByIdAsync(employeeId);
            if (employee == null)
                throw new ArgumentException("Çalışan bulunamadı.");

            if (inventory.AssignedEmployeeId.HasValue)
                throw new InvalidOperationException("Bu demirbaş zaten bir çalışana zimmetli.");

            inventory.AssignedEmployeeId = employeeId;
            inventory.AssignmentDate = DateTime.Now;
            inventory.AssignmentNotes = notes;
            inventory.ModifiedDate = DateTime.Now;

            await UpdateAsync(inventory);
            return true;
        }

        public async Task<bool> UnassignFromEmployeeAsync(int inventoryId, string notes = null)
        {
            var inventory = await GetByIdAsync(inventoryId);
            if (inventory == null)
                throw new ArgumentException("Demirbaş bulunamadı.");

            if (!inventory.AssignedEmployeeId.HasValue)
                throw new InvalidOperationException("Bu demirbaş zaten zimmetsiz.");

            inventory.AssignedEmployeeId = null;
            inventory.AssignmentDate = null;
            inventory.AssignmentNotes = notes;
            inventory.ModifiedDate = DateTime.Now;

            await UpdateAsync(inventory);
            return true;
        }

        public async Task<bool> SendToMaintenanceAsync(int inventoryId, string description)
        {
            var inventory = await GetByIdAsync(inventoryId);
            if (inventory == null)
                throw new ArgumentException("Demirbaş bulunamadı.");

            if (inventory.Status == InventoryStatus.InMaintenance)
                throw new InvalidOperationException("Bu demirbaş zaten bakımda.");

            inventory.Status = InventoryStatus.InMaintenance;
            inventory.ModifiedDate = DateTime.Now;

            var maintenance = new Maintenance
            {
                InventoryId = inventoryId,
                StartDate = DateTime.Now,
                Description = description,
                Status = MaintenanceStatus.InProgress
            };

            await _maintenanceRepository.AddAsync(maintenance);
            await UpdateAsync(inventory);
            return true;
        }

        public async Task<bool> CompleteMaintenanceAsync(int inventoryId, string notes)
        {
            var inventory = await GetByIdAsync(inventoryId);
            if (inventory == null)
                throw new ArgumentException("Demirbaş bulunamadı.");

            if (inventory.Status != InventoryStatus.InMaintenance)
                throw new InvalidOperationException("Bu demirbaş bakımda değil.");

            var maintenance = await _maintenanceRepository.GetActiveMaintenanceByInventoryIdAsync(inventoryId);
            if (maintenance == null)
                throw new InvalidOperationException("Aktif bakım kaydı bulunamadı.");

            maintenance.EndDate = DateTime.Now;
            maintenance.Notes = notes;
            maintenance.Status = MaintenanceStatus.Completed;

            inventory.Status = InventoryStatus.Active;
            inventory.ModifiedDate = DateTime.Now;
            inventory.LastMaintenanceDate = DateTime.Now;

            await _maintenanceRepository.UpdateAsync(maintenance);
            await UpdateAsync(inventory);
            return true;
        }

        public async Task<List<Inventory>> GetExpiredWarrantyItemsAsync()
        {
            return await _inventoryRepository.GetExpiredWarrantyItemsAsync();
        }

        public async Task<List<Inventory>> GetMaintenanceDueItemsAsync()
        {
            return await _inventoryRepository.GetMaintenanceDueItemsAsync();
        }

        public async Task<decimal> GetTotalInventoryValueAsync()
        {
            var allInventory = await GetAllAsync();
            return allInventory.Sum(i => i.CurrentValue ?? 0);
        }

        public async Task<Inventory> GetByInventoryCodeAsync(string inventoryCode)
        {
            return await _inventoryRepository.GetByInventoryCodeAsync(inventoryCode);
        }

        public async Task<bool> IsInventoryCodeUniqueAsync(string inventoryCode)
        {
            var inventory = await GetByInventoryCodeAsync(inventoryCode);
            return inventory == null;
        }

        public async Task<bool> CanBeDeletedAsync(int inventoryId)
        {
            var inventory = await GetByIdAsync(inventoryId);
            if (inventory == null)
                return false;

            // Zimmetli demirbaş kontrolü
            if (inventory.AssignedEmployeeId.HasValue)
                return false;

            // Bakımda olan demirbaş kontrolü
            if (inventory.Status == InventoryStatus.InMaintenance || 
                inventory.Status == InventoryStatus.InRepair)
                return false;

            return true;
        }

        public async Task<bool> CanBeAssignedAsync(int inventoryId)
        {
            var inventory = await GetByIdAsync(inventoryId);
            if (inventory == null)
                return false;

            // Zaten zimmetli mi?
            if (inventory.AssignedEmployeeId.HasValue)
                return false;

            // Aktif durumda mı?
            if (inventory.Status != InventoryStatus.Active)
                return false;

            return true;
        }

        public async Task<bool> CanBeMaintenancedAsync(int inventoryId)
        {
            var inventory = await GetByIdAsync(inventoryId);
            if (inventory == null)
                return false;

            // Zaten bakımda mı?
            if (inventory.Status == InventoryStatus.InMaintenance || 
                inventory.Status == InventoryStatus.InRepair)
                return false;

            // Aktif bir bakım kaydı var mı?
            var activeMaintenance = await _maintenanceRepository.GetActiveMaintenanceByInventoryIdAsync(inventoryId);
            if (activeMaintenance != null)
                return false;

            return true;
        }

    }
} 