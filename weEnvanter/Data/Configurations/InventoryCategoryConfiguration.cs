using System.Data.Entity.ModelConfiguration;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Data.Configurations
{
    public class InventoryCategoryConfiguration : EntityTypeConfiguration<InventoryCategory>
    {
        public InventoryCategoryConfiguration()
        {
            ToTable("InventoryCategories");

            HasOptional(c => c.ParentCategory)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(c => c.ParentCategoryId)
                .WillCascadeOnDelete(false);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.CategoryCode)
                .IsRequired()
                .HasMaxLength(20);

            Property(c => c.Description)
                .HasMaxLength(500);
        }
    }
} 