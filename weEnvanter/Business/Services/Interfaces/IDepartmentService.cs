using System.Collections.Generic;
using System.Threading.Tasks;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Business.Services.Interfaces
{
    public interface IDepartmentService : IBaseService<Department>
    {
        Task<List<Department>> GetByParentDepartmentAsync(int? parentDepartmentId);
        Task<bool> HasEmployeesAsync(int departmentId);
        Task<bool> HasInventoriesAsync(int departmentId);
        Task<Department> GetByDepartmentCodeAsync(string departmentCode);
        Task<bool> IsDepartmentCodeUniqueAsync(string departmentCode);
        Task<bool> CanBeDeletedAsync(int departmentId);
    }
} 