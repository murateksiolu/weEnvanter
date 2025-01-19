using System;
using weEnvanter.Domain.Common;

namespace weEnvanter.Domain.Entities
{
    public class InventoryAssignment : BaseEntity
    {
        public int InventoryId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime AssignmentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int AssignedById { get; set; }
        public string Notes { get; set; }
        public bool IsReturned { get; set; }

        public virtual Inventory Inventory { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual User AssignedBy { get; set; }
    }
} 