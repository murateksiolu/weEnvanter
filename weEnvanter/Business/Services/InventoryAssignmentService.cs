using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Data.Entity;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Business.DTOs;
using weEnvanter.Data.Repositories.Interfaces;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Business.Services
{
    public class InventoryAssignmentService : BaseService<InventoryAssignment>, IInventoryAssignmentService
    {
        private readonly IInventoryAssignmentRepository _assignmentRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IUserRepository _userRepository;

        public InventoryAssignmentService(
            IInventoryAssignmentRepository assignmentRepository,
            IEmployeeRepository employeeRepository,
            IUserRepository userRepository) 
            : base(assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
            _employeeRepository = employeeRepository;
            _userRepository = userRepository;
        }

        public async Task<List<InventoryAssignment>> GetByInventoryIdAsync(int inventoryId)
        {
            return await _assignmentRepository.GetByInventoryIdAsync(inventoryId);
        }

        public async Task<List<InventoryAssignment>> GetByEmployeeIdAsync(int employeeId)
        {
            return await _assignmentRepository.GetByEmployeeIdAsync(employeeId);
        }

        public async Task<InventoryAssignment> GetActiveAssignmentByInventoryIdAsync(int inventoryId)
        {
            return await _assignmentRepository.GetActiveAssignmentByInventoryIdAsync(inventoryId);
        }

        public async Task<List<InventoryAssignmentHistoryDto>> GetInventoryAssignmentHistoryAsync(int inventoryId)
        {
            var assignments = await _assignmentRepository.GetByInventoryIdAsync(inventoryId);
            var employeeIds = assignments.Select(x => x.EmployeeId).Distinct().ToList();
            var assignedByUserIds = assignments.Select(x => x.AssignedById).Distinct().ToList();

            var employees = (await _employeeRepository.GetAllAsync())
                .Where(x => employeeIds.Contains(x.Id))
                .ToDictionary(x => x.Id);

            var users = (await _userRepository.GetAllAsync())
                .Where(x => assignedByUserIds.Contains(x.Id))
                .ToDictionary(x => x.Id);

            return assignments.Select(x => new InventoryAssignmentHistoryDto
            {
                Id = x.Id,
                AssignmentDate = x.AssignmentDate,
                EmployeeName = employees.ContainsKey(x.EmployeeId) 
                    ? $"{employees[x.EmployeeId].FirstName} {employees[x.EmployeeId].LastName}"
                    : "Bilinmiyor",
                EmployeeNumber = employees.ContainsKey(x.EmployeeId)
                    ? employees[x.EmployeeId].EmployeeNumber
                    : "Bilinmiyor",
                DepartmentName = employees.ContainsKey(x.EmployeeId) && employees[x.EmployeeId].Department != null
                    ? employees[x.EmployeeId].Department.Name
                    : "Bilinmiyor",
                Notes = x.Notes,
                IsActive = x.IsActive,
                AssignedByUserName = users.ContainsKey(x.AssignedById)
                    ? users[x.AssignedById].Username
                    : "Bilinmiyor",
                CreatedDate = x.CreatedDate,
                CreatedBy = ""
            }).ToList();
        }
    }
} 