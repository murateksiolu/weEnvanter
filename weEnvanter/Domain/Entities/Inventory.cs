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
            Maintenances = new HashSet<Maintenance>();
        }

        public string InventoryCode { get; set; }
        public string BarcodeNumber { get; set; }
        public string QRCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int InventoryCategoryId { get; set; }
        public int? AssignedEmployeeId { get; set; }
        public DateTime? AssignmentDate { get; set; }
        public string AssignmentNotes { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? CurrentValue { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? WarrantyExpirationDate { get; set; }
        public DateTime? CalibrationDueDate { get; set; }
        public int? CalibrationPeriod { get; set; }
        public DateTime? LastMaintenanceDate { get; set; }
        public DateTime? NextMaintenanceDate { get; set; }
        public int? MaintenancePeriod { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public InventoryStatus Status { get; set; }
        public string SerialNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Supplier { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierEmail { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        // Navigation properties
        public virtual InventoryCategory InventoryCategory { get; set; }
        public virtual Employee AssignedEmployee { get; set; }
        public virtual ICollection<InventoryAssignment> Assignments { get; set; }
        public virtual ICollection<Maintenance> Maintenances { get; set; }
    }
} 