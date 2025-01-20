using System.Collections.Generic;
using System.Threading.Tasks;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Data.Repositories.Interfaces
{
    public interface IDepartmentRepository : IBaseRepository<Department>
    {
        Task<List<Department>> GetActiveAsync();
        Task<Department> GetByCodeAsync(string departmentCode);
        Task<List<Department>> GetByParentDepartmentAsync(int? parentDepartmentId);
        Task<bool> HasEmployeesAsync(int departmentId);
        Task<bool> HasInventoriesAsync(int departmentId);
    }
} 