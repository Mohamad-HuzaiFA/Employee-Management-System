using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using EmployeeManagement_BLL;  // Assuming this is where EmployeeBLL is located
using EmployeeManagement_DAL;  // Assuming this is where EMS_DAL and IEMS_DAL are located

namespace EmployeeManagement
{
    internal static class Program
    {
        private static ServiceProvider serviceProvider;

        [STAThread]
        static void Main()
        {
            ConfigureServices();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Resolve Form1 (or main form) with DI and run the application
            var mainForm = serviceProvider.GetRequiredService<Main>();
            Application.Run(mainForm);
        }

        private static void ConfigureServices()
        {
            var services = new ServiceCollection();

            // Register the DAL with DI (replace the connection string with your actual one)
            services.AddTransient<IEMS_DAL, EMS_DAL>(provider =>
                new EMS_DAL("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EmployeeDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"));

            // Register the BLL with DI, injecting the DAL into it
            services.AddTransient<EmployeeBLL>();

            // Register the form (assuming the form depends on BLL or DAL)
            services.AddTransient<Main>();

            // Build the service provider
            serviceProvider = services.BuildServiceProvider();
        }
    }
}
