using System.Data.Entity.ModelConfiguration;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Data.Configurations
{
    public class MaintenanceRecordConfiguration : EntityTypeConfiguration<MaintenanceRecord>
    {
        public MaintenanceRecordConfiguration()
        {
            ToTable("MaintenanceRecords");

            HasRequired(m => m.Inventory)
                .WithMany(i => i.MaintenanceRecords)
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