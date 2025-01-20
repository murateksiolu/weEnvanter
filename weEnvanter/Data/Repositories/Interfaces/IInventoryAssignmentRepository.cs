using System.Collections.Generic;
using System.Threading.Tasks;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Data.Repositories.Interfaces
{
    public interface IInventoryAssignmentRepository : IBaseRepository<InventoryAssignment>
    {
        Task<List<InventoryAssignment>> GetByInventoryIdAsync(int inventoryId);
        Task<List<InventoryAssignment>> GetByEmployeeIdAsync(int employeeId);
        Task<InventoryAssignment> GetActiveAssignmentByInventoryIdAsync(int inventoryId);
    }
} 