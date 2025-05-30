using System.Configuration;
using Carvo.Data_Access_Layer.Data.Context;
using Carvo.Data_Access_Layer.DataSeeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Carvo.User_Interface_Layer
{
    public class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            var host = Host.CreateDefaultBuilder()
                 .ConfigureServices((context, services) =>
                 {
                     // سجل DbContext
                     services.AddDbContext<CarvoDbContext>(options =>
                         options.UseSqlServer(context.Configuration.GetConnectionString("DefaultConnection")));
                     // سجل الفورم الرئيسي
                     services.AddTransient<MainWindow>();
                     services.AddTransient<InvoiceForm>();
                     services.AddTransient<LoginForm>();
                     services.AddTransient<SalesInvoiceForm>();
                     services.AddTransient<RepairInvoiceForm>();
                     services.AddTransient<DashboardForm>();


                 })
                 .Build();

            // الآن نستخدم scope ونعمل الميجرشن والبيانات
            using (var scope = host.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;

                var dataContext = serviceProvider.GetRequiredService<CarvoDbContext>();
                var loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>();

                try
                {
                    await dataContext.Database.MigrateAsync();
                    await SeedingDataInCarvoDbContext.SeedingData(dataContext);

                 
                }
                catch (Exception ex)
                {
                    var logger = loggerFactory.CreateLogger<Program>();
                    logger.LogError(ex, "There was an error during migration or seeding.");
                }
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // شغّل الفورم من DI
            var mainFrom = host.Services.GetRequiredService<MainWindow>();
            var loginFrom = host.Services.GetRequiredService<LoginForm>();
            var InvoiceFrom = host.Services.GetRequiredService<InvoiceForm>();
            var repairInvoiceFrom = host.Services.GetRequiredService<RepairInvoiceForm>();
            var salesInvoiceFrom = host.Services.GetRequiredService<SalesInvoiceForm>();
            var dashboardForm = host.Services.GetRequiredService<DashboardForm>();

            Application.Run( new AdminDashboardForm());
        }
    }
}