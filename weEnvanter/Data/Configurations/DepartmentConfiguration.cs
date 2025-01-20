using System.Data.Entity.ModelConfiguration;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Data.Configurations
{
    public class DepartmentConfiguration : EntityTypeConfiguration<Department>
    {
        public DepartmentConfiguration()
        {
            ToTable("Departments");

            HasOptional(d => d.ParentDepartment)
                .WithMany(d => d.SubDepartments)
                .HasForeignKey(d => d.ParentDepartmentId)
                .WillCascadeOnDelete(false);

            Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(100);

            Property(d => d.DepartmentCode)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
} 