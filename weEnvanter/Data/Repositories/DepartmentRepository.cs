using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using weEnvanter.Data.Repositories.Interfaces;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Data.Repositories
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(WeEnvanterDbContext context) : base(context)
        {
        }

        public async Task<List<Department>> GetActiveAsync()
        {
            return await _dbSet.Where(x => x.IsActive && !x.IsDeleted)
                .OrderBy(x => x.Name)
                .ToListAsync();
        }

        public async Task<Department> GetByCodeAsync(string departmentCode)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.DepartmentCode == departmentCode && !x.IsDeleted);
        }

        public async Task<List<Department>> GetByParentDepartmentAsync(int? parentDepartmentId)
        {
            return await _dbSet.Where(x => x.ParentDepartmentId == parentDepartmentId && !x.IsDeleted)
                .OrderBy(x => x.Name)
                .ToListAsync();
        }

        public async Task<bool> HasEmployeesAsync(int departmentId)
        {
            return await _context.Employees.AnyAsync(x => x.DepartmentId == departmentId && !x.IsDeleted);
        }

        public async Task<bool> HasInventoriesAsync(int departmentId)
        {
            return await _context.Inventories.AnyAsync(x => x.DepartmentId == departmentId && !x.IsDeleted);
        }
    }
} 