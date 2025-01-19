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

        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public string BarcodeNumber { get; set; }
        public int CategoryId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal PurchasePrice { get; set; }
        public DateTime? WarrantyEndDate { get; set; }
        public InventoryStatus Status { get; set; }
        public string Description { get; set; }
        public string PhotoPath { get; set; }

        public virtual InventoryCategory Category { get; set; }
        public virtual ICollection<InventoryAssignment> Assignments { get; set; }
        public virtual ICollection<MaintenanceRecord> MaintenanceRecords { get; set; }
    }
} 