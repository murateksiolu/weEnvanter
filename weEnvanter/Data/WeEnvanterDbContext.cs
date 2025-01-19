using System.Data.Entity;
using weEnvanter.Domain.Entities;
using System;
using System.Linq;
using weEnvanter.Domain.Enums;

namespace weEnvanter.Data
{
    public class WeEnvanterDbContext : DbContext
    {
        public WeEnvanterDbContext() : base("name=WeEnvanterConnection")
        {
            Database.SetInitializer(new WeEnvanterDbInitializer());
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<InventoryAssignment> InventoryAssignments { get; set; }
        public DbSet<InventoryCategory> InventoryCategories { get; set; }
        public DbSet<MaintenanceRecord> MaintenanceRecords { get; set; }
        public DbSet<SystemLog> SystemLogs { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().ToTable("Departments");
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<Inventory>().ToTable("Inventories");
            modelBuilder.Entity<InventoryAssignment>().ToTable("InventoryAssignments");
            modelBuilder.Entity<InventoryCategory>().ToTable("InventoryCategories");
            modelBuilder.Entity<MaintenanceRecord>().ToTable("MaintenanceRecords");
            modelBuilder.Entity<SystemLog>().ToTable("SystemLogs");
            modelBuilder.Entity<User>().ToTable("Users");

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
                    Password = "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918", // admin
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