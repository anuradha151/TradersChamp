using Microsoft.Extensions.DependencyInjection;
using TradersChamp.Data;
using TradersChamp.Model;
using TradersChamp.Service;
using TradersChamp.View;
using TradersChamp.View.Customer;

namespace TradersChamp
{
    internal static class Program
    {
        public static ServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // ApplicationConfiguration.Initialize();
            // Application.Run(new Login());

            // Setup Dependency Injection
            var services = new ServiceCollection();
            ConfigureServices(services);

            ServiceProvider = services.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(ServiceProvider.GetRequiredService<Login>());
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<MailService>(); 
            services.AddSingleton<ApplicationDBContext>();
            services.AddTransient<SignUp>();
            services.AddTransient<Login>();
            services.AddTransient<Users>();
            services.AddTransient<CustomerPortal>();
        }
    }
}