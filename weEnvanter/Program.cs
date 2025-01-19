using AutoMapper;
using System;
using System.Windows.Forms;
using weEnvanter.Business.DTOs;
using weEnvanter.Business.Mapping;
using weEnvanter.UI.Forms.Auth;
using Microsoft.Extensions.DependencyInjection;
using weEnvanter.Business.Services;
using System.Configuration;
using weEnvanter.Data;
using weEnvanter.Data.Repositories;

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
            services.AddScoped<WeEnvanterDbContext>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUserService, UserService>();
            services.AddTransient<LoginForm>();
        }
    }
}
