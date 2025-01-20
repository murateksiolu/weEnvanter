using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using weEnvanter.Data.Repositories.Interfaces;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Data.Repositories
{
    public class InventoryAssignmentRepository : BaseRepository<InventoryAssignment>, IInventoryAssignmentRepository
    {
        public InventoryAssignmentRepository(WeEnvanterDbContext context) : base(context)
        {
        }

        public async Task<List<InventoryAssignment>> GetByInventoryIdAsync(int inventoryId)
        {
            return await _dbSet.Where(x => x.InventoryId == inventoryId && !x.IsDeleted)
                .OrderByDescending(x => x.AssignmentDate)
                .ToListAsync();
        }

        public async Task<List<InventoryAssignment>> GetByEmployeeIdAsync(int employeeId)
        {
            return await _dbSet.Where(x => x.EmployeeId == employeeId && !x.IsDeleted)
                .OrderByDescending(x => x.AssignmentDate)
                .ToListAsync();
        }

        public async Task<InventoryAssignment> GetActiveAssignmentByInventoryIdAsync(int inventoryId)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.InventoryId == inventoryId && 
                x.IsActive && !x.IsDeleted);
        }
    }
} 