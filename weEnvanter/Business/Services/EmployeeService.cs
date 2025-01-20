using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Data.Repositories.Interfaces;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Business.Services
{
    public class EmployeeService : BaseService<Employee>, IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IInventoryRepository _inventoryRepository;

        public EmployeeService(
            IEmployeeRepository employeeRepository,
            IInventoryRepository inventoryRepository) : base(employeeRepository)
        {
            _employeeRepository = employeeRepository;
            _inventoryRepository = inventoryRepository;
        }

        public override async Task<Employee> AddAsync(Employee employee)
        {
            if (string.IsNullOrEmpty(employee.EmployeeNumber))
                throw new ArgumentException("Sicil numarası boş olamaz.");

            if (string.IsNullOrEmpty(employee.FirstName))
                throw new ArgumentException("Ad boş olamaz.");

            if (string.IsNullOrEmpty(employee.LastName))
                throw new ArgumentException("Soyad boş olamaz.");

            var existingEmployee = await _employeeRepository.GetByEmployeeNumberAsync(employee.EmployeeNumber);
            if (existingEmployee != null)
                throw new InvalidOperationException("Bu sicil numarası zaten kullanılıyor.");

            employee.CreatedDate = DateTime.Now;
            employee.IsActive = true;

            return await base.AddAsync(employee);
        }

        public override async Task<Employee> UpdateAsync(Employee employee)
        {
            var existingEmployee = await GetByIdAsync(employee.Id);
            if (existingEmployee == null)
                throw new ArgumentException("Güncellenecek çalışan bulunamadı.");

            if (employee.EmployeeNumber != existingEmployee.EmployeeNumber)
            {
                var employeeWithSameNumber = await _employeeRepository.GetByEmployeeNumberAsync(employee.EmployeeNumber);
                if (employeeWithSameNumber != null)
                    throw new InvalidOperationException("Bu sicil numarası başka bir çalışan tarafından kullanılıyor.");
            }

            employee.ModifiedDate = DateTime.Now;
            return await base.UpdateAsync(employee);
        }

        public override async Task<bool> DeleteAsync(int id)
        {
            var employee = await GetByIdAsync(id);
            if (employee == null)
                throw new ArgumentException("Silinecek çalışan bulunamadı.");

            var assignedInventories = await _inventoryRepository.GetByEmployeeAsync(id);
            if (assignedInventories.Count > 0)
                throw new InvalidOperationException("Zimmetli demirbaşı olan çalışan silinemez. Önce zimmetleri düşürün.");

            return await base.DeleteAsync(id);
        }

        public async Task<List<Employee>> GetByDepartmentAsync(int departmentId)
        {
            return await _employeeRepository.GetByDepartmentAsync(departmentId);
        }

        public async Task<List<Employee>> GetActiveEmployeesAsync()
        {
            return await _employeeRepository.GetByStatusAsync(true);
        }

        public async Task<List<Employee>> GetInactiveEmployeesAsync()
        {
            return await _employeeRepository.GetByStatusAsync(false);
        }

        public async Task<List<Inventory>> GetAssignedInventoriesAsync(int employeeId)
        {
            return await _inventoryRepository.GetByEmployeeAsync(employeeId);
        }

        public async Task<bool> DeactivateEmployeeAsync(int employeeId)
        {
            var employee = await GetByIdAsync(employeeId);
            if (employee == null)
                throw new ArgumentException("Çalışan bulunamadı.");

            if (!employee.IsActive)
                throw new InvalidOperationException("Çalışan zaten pasif durumda.");

            var assignedInventories = await _inventoryRepository.GetByEmployeeAsync(employeeId);
            if (assignedInventories.Count > 0)
                throw new InvalidOperationException("Zimmetli demirbaşı olan çalışan pasife alınamaz. Önce zimmetleri düşürün.");

            employee.IsActive = false;
            employee.ModifiedDate = DateTime.Now;

            await UpdateAsync(employee);
            return true;
        }

        public async Task<bool> ActivateEmployeeAsync(int employeeId)
        {
            var employee = await GetByIdAsync(employeeId);
            if (employee == null)
                throw new ArgumentException("Çalışan bulunamadı.");

            if (employee.IsActive)
                throw new InvalidOperationException("Çalışan zaten aktif durumda.");

            employee.IsActive = true;
            employee.ModifiedDate = DateTime.Now;

            await UpdateAsync(employee);
            return true;
        }

        public async Task<Employee> GetByEmployeeCodeAsync(string employeeCode)
        {
            return await _employeeRepository.GetByEmployeeNumberAsync(employeeCode);
        }

        public async Task<bool> IsEmployeeCodeUniqueAsync(string employeeCode)
        {
            return await _employeeRepository.IsEmployeeNumberUniqueAsync(employeeCode);
        }

        public async Task<bool> HasAssignedInventoriesAsync(int employeeId)
        {
            return await _employeeRepository.HasAssignedInventoriesAsync(employeeId);
        }

        public async Task<bool> CanBeDeletedAsync(int employeeId)
        {
            var employee = await GetByIdAsync(employeeId);
            if (employee == null)
                return false;

            // Zimmetli demirbaşı olan çalışan silinemez
            var hasInventories = await HasAssignedInventoriesAsync(employeeId);
            if (hasInventories)
                return false;

            return true;
        }
    }
} 