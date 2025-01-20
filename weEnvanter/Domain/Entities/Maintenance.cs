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
        public MaintenanceType MaintenanceType { get; set; }
        public decimal? Cost { get; set; }
        public string PerformedBy { get; set; }
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPhone { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? NextMaintenanceDate { get; set; }
        public string ReplacedParts { get; set; }
        public string Recommendations { get; set; }
        public string FailureDescription { get; set; }
        public string Resolution { get; set; }
        public int? WarrantyPeriodInDays { get; set; }
        public bool IsUnderWarranty { get; set; }

        // Navigation properties
        public virtual Inventory Inventory { get; set; }
    }
} 