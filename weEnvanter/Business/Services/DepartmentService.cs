using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Data.Repositories.Interfaces;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Business.Services
{
    public class DepartmentService : BaseService<Department>, IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IInventoryRepository _inventoryRepository;

        public DepartmentService(
            IDepartmentRepository departmentRepository,
            IEmployeeRepository employeeRepository,
            IInventoryRepository inventoryRepository) : base(departmentRepository)
        {
            _departmentRepository = departmentRepository;
            _employeeRepository = employeeRepository;
            _inventoryRepository = inventoryRepository;
        }

        public override async Task<Department> AddAsync(Department department)
        {
            if (string.IsNullOrEmpty(department.Name))
                throw new ArgumentException("Departman adı boş olamaz.");

            if (string.IsNullOrEmpty(department.DepartmentCode))
                throw new ArgumentException("Departman kodu boş olamaz.");

            var existingDepartment = await _departmentRepository.GetByCodeAsync(department.DepartmentCode);
            if (existingDepartment != null)
                throw new InvalidOperationException("Bu departman kodu zaten kullanılıyor.");

            department.CreatedDate = DateTime.Now;
            department.IsActive = true;

            return await base.AddAsync(department);
        }

        public override async Task<Department> UpdateAsync(Department department)
        {
            var existingDepartment = await GetByIdAsync(department.Id);
            if (existingDepartment == null)
                throw new ArgumentException("Güncellenecek departman bulunamadı.");

            if (department.DepartmentCode != existingDepartment.DepartmentCode)
            {
                var departmentWithSameCode = await _departmentRepository.GetByCodeAsync(department.DepartmentCode);
                if (departmentWithSameCode != null)
                    throw new InvalidOperationException("Bu departman kodu başka bir departman tarafından kullanılıyor.");
            }

            department.ModifiedDate = DateTime.Now;
            return await base.UpdateAsync(department);
        }

        public override async Task<bool> DeleteAsync(int id)
        {
            var department = await GetByIdAsync(id);
            if (department == null)
                throw new ArgumentException("Silinecek departman bulunamadı.");

            var employees = await _employeeRepository.GetByDepartmentAsync(id);
            if (employees.Count > 0)
                throw new InvalidOperationException("Çalışanı olan departman silinemez.");

            var inventories = await _inventoryRepository.GetByDepartmentAsync(id);
            if (inventories.Count > 0)
                throw new InvalidOperationException("Demirbaşı olan departman silinemez.");

            return await base.DeleteAsync(id);
        }

        public async Task<List<Department>> GetActiveAsync()
        {
            return await _departmentRepository.GetActiveAsync();
        }

        public async Task<Department> GetByCodeAsync(string departmentCode)
        {
            return await _departmentRepository.GetByCodeAsync(departmentCode);
        }

        public async Task<bool> DeactivateDepartmentAsync(int departmentId)
        {
            var department = await GetByIdAsync(departmentId);
            if (department == null)
                throw new ArgumentException("Departman bulunamadı.");

            if (!department.IsActive)
                throw new InvalidOperationException("Departman zaten pasif durumda.");

            var employees = await _employeeRepository.GetByDepartmentAsync(departmentId);
            if (employees.Count > 0)
                throw new InvalidOperationException("Çalışanı olan departman pasife alınamaz.");

            var inventories = await _inventoryRepository.GetByDepartmentAsync(departmentId);
            if (inventories.Count > 0)
                throw new InvalidOperationException("Demirbaşı olan departman pasife alınamaz.");

            department.IsActive = false;
            department.ModifiedDate = DateTime.Now;

            await UpdateAsync(department);
            return true;
        }

        public async Task<bool> ActivateDepartmentAsync(int departmentId)
        {
            var department = await GetByIdAsync(departmentId);
            if (department == null)
                throw new ArgumentException("Departman bulunamadı.");

            if (department.IsActive)
                throw new InvalidOperationException("Departman zaten aktif durumda.");

            department.IsActive = true;
            department.ModifiedDate = DateTime.Now;

            await UpdateAsync(department);
            return true;
        }

        public async Task<List<Employee>> GetDepartmentEmployeesAsync(int departmentId)
        {
            return await _employeeRepository.GetByDepartmentAsync(departmentId);
        }

        public async Task<List<Inventory>> GetDepartmentInventoriesAsync(int departmentId)
        {
            return await _inventoryRepository.GetByDepartmentAsync(departmentId);
        }

        public async Task<List<Department>> GetByParentDepartmentAsync(int? parentDepartmentId)
        {
            return await _departmentRepository.GetByParentDepartmentAsync(parentDepartmentId);
        }

        public async Task<bool> HasEmployeesAsync(int departmentId)
        {
            return await _departmentRepository.HasEmployeesAsync(departmentId);
        }

        public async Task<bool> HasInventoriesAsync(int departmentId)
        {
            return await _departmentRepository.HasInventoriesAsync(departmentId);
        }

        public async Task<Department> GetByDepartmentCodeAsync(string departmentCode)
        {
            return await _departmentRepository.GetByCodeAsync(departmentCode);
        }

        public async Task<bool> IsDepartmentCodeUniqueAsync(string departmentCode)
        {
            var existingDepartment = await _departmentRepository.GetByCodeAsync(departmentCode);
            return existingDepartment == null;
        }

        public async Task<bool> CanBeDeletedAsync(int departmentId)
        {
            var hasEmployees = await HasEmployeesAsync(departmentId);
            if (hasEmployees)
                return false;

            var hasInventories = await HasInventoriesAsync(departmentId);
            if (hasInventories)
                return false;

            return true;
        }
    }
} 