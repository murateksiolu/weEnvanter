using System.Data.Entity.ModelConfiguration;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Data.Configurations
{
    public class InventoryAssignmentConfiguration : EntityTypeConfiguration<InventoryAssignment>
    {
        public InventoryAssignmentConfiguration()
        {
            ToTable("InventoryAssignments");

            HasRequired(a => a.Inventory)
                .WithMany(i => i.Assignments)
                .HasForeignKey(a => a.InventoryId)
                .WillCascadeOnDelete(false);

            HasRequired(a => a.Employee)
                .WithMany()
                .HasForeignKey(a => a.EmployeeId)
                .WillCascadeOnDelete(false);
        }
    }
} 