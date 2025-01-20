using System.Data.Entity.ModelConfiguration;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Data.Configurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("Users");

            Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(50);

            Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(100);

            Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(50);

            Property(u => u.Email)
                .HasMaxLength(100);

            Property(u => u.Phone)
                .HasMaxLength(20);
        }
    }
} 