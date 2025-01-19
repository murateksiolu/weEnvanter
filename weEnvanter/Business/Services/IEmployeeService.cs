using System.Collections.Generic;
using System.Threading.Tasks;
using weEnvanter.Business.DTOs;

namespace weEnvanter.Business.Services
{
    public interface IEmployeeService
    {
        Task<EmployeeDto> GetByIdAsync(int id);
        Task<IEnumerable<EmployeeDto>> GetAllAsync();
        Task<IEnumerable<EmployeeDto>> GetByDepartmentAsync(int departmentId);
        Task<EmployeeDto> CreateAsync(EmployeeCreateDto createDto);
        Task<EmployeeDto> UpdateAsync(int id, EmployeeUpdateDto updateDto);
        Task DeleteAsync(int id);
        Task<bool> IsEmployeeNumberUniqueAsync(string employeeNumber);
    }
} 