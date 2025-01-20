using System.Data.Entity;
using weEnvanter.Domain.Entities;
using System;
using System.Linq;
using weEnvanter.Domain.Enums;
using weEnvanter.Data.Configurations;

namespace weEnvanter.Data
{
    public class WeEnvanterDbContext : DbContext
    {
        public WeEnvanterDbContext() : base("name=WeEnvanterRemoteConnection")
        {
            Database.SetInitializer(new WeEnvanterDbInitializer());
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<InventoryAssignment> InventoryAssignments { get; set; }
        public DbSet<InventoryCategory> InventoryCategories { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<SystemLog> SystemLogs { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DepartmentConfiguration());
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
            modelBuilder.Configurations.Add(new InventoryConfiguration());
            modelBuilder.Configurations.Add(new InventoryAssignmentConfiguration());
            modelBuilder.Configurations.Add(new InventoryCategoryConfiguration());
            modelBuilder.Configurations.Add(new MaintenanceConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }

    public class WeEnvanterDbInitializer : CreateDatabaseIfNotExists<WeEnvanterDbContext>
    {
        protected override void Seed(WeEnvanterDbContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.Add(new User
                {
                    Username = "admin",
                    Password = "jGl25bVBBBW96Qi9Te4V37Fnqchz/Eu4qB9vKrRIqRg=", // admin
                    FirstName = "System",
                    LastName = "Admin",
                    Role = UserRole.Admin,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                });
                context.SaveChanges();
            }
            base.Seed(context);
        }
    }
}