using System;
using weEnvanter.Domain.Common;
using weEnvanter.Domain.Enums;

namespace weEnvanter.Domain.Entities
{
    public class MaintenanceRecord : BaseEntity
    {
        public int InventoryId { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public DateTime? NextMaintenanceDate { get; set; }
        public MaintenanceType MaintenanceType { get; set; }
        public string Description { get; set; }
        public decimal? Cost { get; set; }
        public string PerformedBy { get; set; }
        public bool IsCompleted { get; set; }

        public virtual Inventory Inventory { get; set; }
    }
} 