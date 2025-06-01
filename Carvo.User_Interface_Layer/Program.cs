using System.Configuration;
using Carvo.Business_Logic_Layer.IServices;
using Carvo.Business_Logic_Layer.Services;
using Carvo.Data_Access_Layer.Data.Context;
using Carvo.Data_Access_Layer.DataSeeding;
using Carvo.Data_Access_Layer.Repository.GenericRepositories;
using Carvo.Data_Access_Layer.Repository.IGenericRepositories;
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
                     services.AddTransient<InvoiceForm>();
                     services.AddTransient<LoginForm>();
                     services.AddTransient<SalesInvoiceForm>();
                     services.AddTransient<RepairInvoiceForm>();
                     services.AddTransient<DashboardForm>();
                     services.AddTransient<AdminCategoriesForm>();


                     services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
                     services.AddScoped<ICategoryService, CategoryService>();



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
            var loginFrom = host.Services.GetRequiredService<LoginForm>();
            var InvoiceFrom = host.Services.GetRequiredService<InvoiceForm>();
            var adminCategoriesForm = host.Services.GetRequiredService<AdminCategoriesForm>();
         
            var service = host.Services.GetRequiredService<ICategoryService>();

            Application.Run(adminCategoriesForm);
        }
    }
}