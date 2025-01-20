using System.Collections.Generic;
using System.Threading.Tasks;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Business.Services.Interfaces
{
    public interface IEmployeeService : IBaseService<Employee>
    {
        Task<List<Employee>> GetByDepartmentAsync(int departmentId);
        Task<Employee> GetByEmployeeCodeAsync(string employeeCode);
        Task<bool> IsEmployeeCodeUniqueAsync(string employeeCode);
        Task<List<Inventory>> GetAssignedInventoriesAsync(int employeeId);
        Task<bool> HasAssignedInventoriesAsync(int employeeId);
        Task<bool> CanBeDeletedAsync(int employeeId);

        // Dashboard için eklenen metodlar
        int GetActiveEmployeeCount();
    }
} 