using System.Collections.Generic;
using System.Threading.Tasks;
using weEnvanter.Business.DTOs;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Business.Services.Interfaces
{
    public interface IInventoryAssignmentService : IBaseService<InventoryAssignment>
    {
        Task<List<InventoryAssignment>> GetByInventoryIdAsync(int inventoryId);
        Task<List<InventoryAssignment>> GetByEmployeeIdAsync(int employeeId);
        Task<InventoryAssignment> GetActiveAssignmentByInventoryIdAsync(int inventoryId);
        Task<List<InventoryAssignmentHistoryDto>> GetInventoryAssignmentHistoryAsync(int inventoryId);
    }
} 