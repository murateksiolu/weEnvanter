using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using weEnvanter.Data.Repositories.Interfaces;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Data.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(WeEnvanterDbContext context) : base(context)
        {
        }

        public async Task<List<Employee>> GetByDepartmentAsync(int departmentId)
        {
            return await _dbSet.Where(x => x.DepartmentId == departmentId && !x.IsDeleted)
                .OrderBy(x => x.FirstName).ThenBy(x => x.LastName)
                .ToListAsync();
        }

        public async Task<List<Employee>> GetByStatusAsync(bool isActive)
        {
            return await _dbSet.Where(x => x.IsActive == isActive && !x.IsDeleted)
                .OrderBy(x => x.FirstName).ThenBy(x => x.LastName)
                .ToListAsync();
        }

        public async Task<Employee> GetByEmployeeNumberAsync(string employeeNumber)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.EmployeeNumber == employeeNumber && !x.IsDeleted);
        }

        public async Task<bool> HasAssignedInventoriesAsync(int employeeId)
        {
            return await _context.Inventories.AnyAsync(x => x.AssignedEmployeeId == employeeId && !x.IsDeleted);
        }

        public async Task<bool> IsEmployeeNumberUniqueAsync(string employeeNumber)
        {
            return !await _dbSet.AnyAsync(x => x.EmployeeNumber == employeeNumber && !x.IsDeleted);
        }
    }
} 