using System;
using System.Collections.Generic;
using weEnvanter.Domain.Common;
using weEnvanter.Domain.Enums;

namespace weEnvanter.Domain.Entities
{
    public class Inventory : BaseEntity
    {
        public Inventory()
        {
            Assignments = new HashSet<InventoryAssignment>();
            MaintenanceRecords = new HashSet<MaintenanceRecord>();
        }

        public string InventoryCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int InventoryCategoryId { get; set; }
        public int DepartmentId { get; set; }
        public int? AssignedEmployeeId { get; set; }
        public DateTime? AssignmentDate { get; set; }
        public string AssignmentNotes { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? CurrentValue { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? WarrantyEndDate { get; set; }
        public DateTime? LastMaintenanceDate { get; set; }
        public DateTime? NextMaintenanceDate { get; set; }
        public InventoryStatus Status { get; set; }

        // Navigation properties
        public virtual InventoryCategory InventoryCategory { get; set; }
        public virtual Department Department { get; set; }
        public virtual Employee AssignedEmployee { get; set; }
        public virtual ICollection<InventoryAssignment> Assignments { get; set; }
        public virtual ICollection<MaintenanceRecord> MaintenanceRecords { get; set; }
    }
} 