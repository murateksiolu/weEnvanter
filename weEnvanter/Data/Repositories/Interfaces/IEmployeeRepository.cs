using System.Collections.Generic;
using System.Threading.Tasks;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Data.Repositories.Interfaces
{
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        Task<List<Employee>> GetByDepartmentAsync(int departmentId);
        Task<List<Employee>> GetByStatusAsync(bool isActive);
        Task<Employee> GetByEmployeeNumberAsync(string employeeNumber);
        Task<bool> HasAssignedInventoriesAsync(int employeeId);
        Task<bool> IsEmployeeNumberUniqueAsync(string employeeNumber);
    }
} 