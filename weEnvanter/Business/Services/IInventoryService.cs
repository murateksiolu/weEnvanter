using System.Collections.Generic;
using System.Threading.Tasks;
using weEnvanter.Business.DTOs;
using weEnvanter.Domain.Enums;

namespace weEnvanter.Business.Services
{
    public interface IInventoryService
    {
        Task<InventoryDto> GetByIdAsync(int id);
        Task<IEnumerable<InventoryDto>> GetAllAsync();
        Task<IEnumerable<InventoryDto>> GetByCategoryAsync(int categoryId);
        Task<IEnumerable<InventoryDto>> GetByStatusAsync(InventoryStatus status);
        Task<InventoryDto> CreateAsync(InventoryCreateDto createDto);
        Task<InventoryDto> UpdateAsync(int id, InventoryUpdateDto updateDto);
        Task DeleteAsync(int id);
        Task<bool> IsSerialNumberUniqueAsync(string serialNumber);
        Task<bool> IsBarcodeNumberUniqueAsync(string barcodeNumber);
        Task<InventoryDto> AssignToEmployeeAsync(int inventoryId, int employeeId, int assignedById);
        Task<InventoryDto> UnassignFromEmployeeAsync(int inventoryId);
    }
} 