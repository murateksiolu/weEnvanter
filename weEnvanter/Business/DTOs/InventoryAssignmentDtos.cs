using System;

namespace weEnvanter.Business.DTOs
{
    public class InventoryAssignmentDto
    {
        public int Id { get; set; }
        public int InventoryId { get; set; }
        public string InventoryName { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime AssignmentDate { get; set; }
    }

    public class InventoryAssignmentCreateDto
    {
        public int InventoryId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime AssignmentDate { get; set; }
    }

    public class InventoryAssignmentUpdateDto
    {
        public int Id { get; set; }
        public int InventoryId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime AssignmentDate { get; set; }
    }
} 