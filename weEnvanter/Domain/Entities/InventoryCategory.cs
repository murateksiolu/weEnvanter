using System.Collections.Generic;
using weEnvanter.Domain.Common;

namespace weEnvanter.Domain.Entities
{
    public class InventoryCategory : BaseEntity
    {
        public InventoryCategory()
        {
            Inventories = new HashSet<Inventory>();
            SubCategories = new HashSet<InventoryCategory>();
        }

        public string CategoryCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int? ParentCategoryId { get; set; }

        public virtual InventoryCategory ParentCategory { get; set; }
        public virtual ICollection<InventoryCategory> SubCategories { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
    }
} 