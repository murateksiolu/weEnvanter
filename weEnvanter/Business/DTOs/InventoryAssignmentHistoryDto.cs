using System;

namespace weEnvanter.Business.DTOs
{
    public class InventoryAssignmentHistoryDto
    {
        public int Id { get; set; }
        public DateTime AssignmentDate { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeNumber { get; set; }
        public string DepartmentName { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        public string AssignedByUserName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
} 