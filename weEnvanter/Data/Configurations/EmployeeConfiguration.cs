using System.Data.Entity.ModelConfiguration;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Data.Configurations
{
    public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            ToTable("Employees");

            HasRequired(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId)
                .WillCascadeOnDelete(false);

            Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50);

            Property(e => e.EmployeeNumber)
                .IsRequired()
                .HasMaxLength(20);

            Property(e => e.Email)
                .HasMaxLength(100);

            Property(e => e.Phone)
                .HasMaxLength(20);
        }
    }
} 