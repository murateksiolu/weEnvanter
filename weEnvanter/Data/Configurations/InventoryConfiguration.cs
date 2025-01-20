using System.Data.Entity.ModelConfiguration;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Data.Configurations
{
    public class InventoryConfiguration : EntityTypeConfiguration<Inventory>
    {
        public InventoryConfiguration()
        {
            ToTable("Inventories");

            HasRequired(i => i.InventoryCategory)
                .WithMany(c => c.Inventories)
                .HasForeignKey(i => i.InventoryCategoryId)
                .WillCascadeOnDelete(false);

            HasRequired(i => i.Department)
                .WithMany()
                .HasForeignKey(i => i.DepartmentId)
                .WillCascadeOnDelete(false);

            HasOptional(i => i.AssignedEmployee)
                .WithMany()
                .HasForeignKey(i => i.AssignedEmployeeId)
                .WillCascadeOnDelete(false);

            Property(i => i.Name)
                .IsRequired()
                .HasMaxLength(100);

            Property(i => i.InventoryCode)
                .IsRequired()
                .HasMaxLength(20);

            Property(i => i.Description)
                .HasMaxLength(500);

            Property(i => i.AssignmentNotes)
                .HasMaxLength(500);
        }
    }
} 