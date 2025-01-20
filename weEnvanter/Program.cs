using AutoMapper;
using System;
using System.Windows.Forms;
using weEnvanter.Business.DTOs;
using weEnvanter.Business.Mapping;
using weEnvanter.UI.Forms.Auth;
using weEnvanter.UI.Forms.InventoryForms;
using Microsoft.Extensions.DependencyInjection;
using weEnvanter.Business.Services;
using weEnvanter.Business.Services.Interfaces;
using System.Configuration;
using weEnvanter.Data;
using weEnvanter.Data.Repositories;
using weEnvanter.Data.Repositories.Interfaces;

namespace weEnvanter
{
    internal static class Program
    {
        public static UserDto CurrentUser;
        private static IServiceProvider ServiceProvider;

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
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IInventoryRepository, InventoryRepository>();
            services.AddScoped<IInventoryCategoryRepository, InventoryCategoryRepository>();
            services.AddScoped<IMaintenanceRepository, MaintenanceRepository>();

            // Services
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IInventoryService, InventoryService>();
            services.AddScoped<IInventoryCategoryService, InventoryCategoryService>();
            services.AddScoped<IMaintenanceService, MaintenanceService>();

            // Forms
            services.AddTransient<LoginForm>();
            services.AddTransient<InventoryListForm>();
        }
    }
}
