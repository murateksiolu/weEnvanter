using System;
using weEnvanter.Domain.Common;
using weEnvanter.Domain.Enums;

namespace weEnvanter.Domain.Entities
{
    public class Maintenance : BaseEntity
    {
        public int InventoryId { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Notes { get; set; }
        public MaintenanceStatus Status { get; set; }

        // Navigation properties
        public virtual Inventory Inventory { get; set; }
    }
} 