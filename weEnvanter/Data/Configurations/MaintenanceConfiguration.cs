using System.Data.Entity.ModelConfiguration;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Data.Configurations
{
    public class MaintenanceConfiguration : EntityTypeConfiguration<Maintenance>
    {
        public MaintenanceConfiguration()
        {
            ToTable("Maintenances");

            HasRequired(m => m.Inventory)
                .WithMany(i => i.Maintenances)
                .HasForeignKey(m => m.InventoryId)
                .WillCascadeOnDelete(false);

            Property(m => m.Description)
                .IsRequired()
                .HasMaxLength(500);

            Property(m => m.Notes)
                .HasMaxLength(500);
        }
    }
} 