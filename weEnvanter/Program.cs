using AutoMapper;
using System;
using System.Windows.Forms;
using weEnvanter.Business.DTOs;
using weEnvanter.Business.Mapping;
using weEnvanter.UI.Forms.AuthForms;
using weEnvanter.UI.Forms.InventoryForms;
using Microsoft.Extensions.DependencyInjection;
using weEnvanter.Business.Services;
using weEnvanter.Business.Services.Interfaces;
using System.Configuration;
using weEnvanter.Data;
using weEnvanter.Data.Repositories;
using weEnvanter.Data.Repositories.Interfaces;
using weEnvanter.UI.Forms.MainForms;
using weEnvanter.UI.Forms.DepartmentForms;
using weEnvanter.UI.Forms.EmployeeForms;
using weEnvanter.UI.Forms.MaintenanceForms;

namespace weEnvanter
{
    internal static class Program
    {
        public static UserDto CurrentUser;
        public static IServiceProvider ServiceProvider;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);

            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(ServiceProvider.GetRequiredService<LoginForm>());
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            // DbContext
            services.AddScoped<WeEnvanterDbContext>();

            // Repositories
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IInventoryRepository, InventoryRepository>();
            services.AddScoped<IInventoryAssignmentRepository, InventoryAssignmentRepository>();
            services.AddScoped<IInventoryCategoryRepository, InventoryCategoryRepository>();
            services.AddScoped<IMaintenanceRepository, MaintenanceRepository>();
            services.AddScoped<ISystemLogRepository, SystemLogRepository>();

            // Services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IInventoryService, InventoryService>();
            services.AddScoped<IInventoryAssignmentService, InventoryAssignmentService>();
            services.AddScoped<IInventoryCategoryService, InventoryCategoryService>();
            services.AddScoped<IMaintenanceService, MaintenanceService>();
            services.AddScoped<ISystemLogService, SystemLogService>();

            // Forms
            services.AddTransient<LoginForm>();
            services.AddTransient<MainForm>();
            services.AddTransient<DepartmentListForm>();
            services.AddTransient<MaintenanceListForm>();
            services.AddTransient<EmployeeListForm>();
        }
    }
}
