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
using Microsoft.Extensions.DependencyInjection.Extensions;
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
        static void Main()
        {
            var host = Host.CreateDefaultBuilder()
                 .ConfigureServices((context, services) =>
                 {
                     // سجل DbContext
                     services.AddDbContextFactory<CarvoDbContext>(options =>
                         options.UseSqlServer(context.Configuration.GetConnectionString("DefaultConnection"))
                         ,ServiceLifetime.Scoped);
                     
                     // سجل الفورم الرئيسي
                     services.AddTransient<AddAlertForm>();
                     services.AddTransient<AdminCategoriesForm>();
                     services.AddTransient<AdminCustomersForm>();
                     services.AddTransient<AdminEmployeesForm>();
                     services.AddTransient<AdminInvoicesForm>();
                     services.AddTransient<AdminProductsForm>();
                     services.AddTransient<AdminSuppliersForm>();
                     services.AddTransient<AlertIncompleteInformationForm>();
                     services.AddTransient<AlertSelectAndDeleteForm>();
                     services.AddTransient<DashboardForm>();
                     services.AddTransient<DeleteAlertForm>();
                     services.AddTransient<HomeDashboardForm>();
                     services.AddTransient<InvoiceForm>();
                     services.AddTransient<InvoiceTypeForm>();
                     services.AddTransient<LoginForm>();
                     services.AddTransient<MainWindowFrom>();
                     services.AddTransient<RepairInvoiceForm>();
                     services.AddTransient<SalesInvoiceForm>();
                     services.AddTransient<UpdateAlertForm>();
                     services.AddTransient<VehicleDashboardForm>();
                     services.AddTransient<EmployeeDashboardForm>();
                     services.AddTransient<PaidSalesInvoiceForm>();
                     services.AddTransient<IUserService , UserService>();
                     







                     services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
                     services.AddScoped<ICategoryService, CategoryService>();
                     services.AddScoped<IProductService, ProductService>();
                     services.AddScoped<ISupplierService, SupplierService>();
                     services.AddScoped<IVehicleService, VehicleService>();
                     services.AddScoped<ICustomerService, CustomerService>();
                     services.AddScoped<IInvoiceProductService, InvoiceProductService>();
                     services.AddScoped<IInvoiceService, InvoiceService>();






                 })
                 .Build();

            // الآن نستخدم scope ونعمل الميجرشن والبيانات
            using (var scope = host.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;

                var dataContext = serviceProvider.GetRequiredService<CarvoDbContext>();
                var loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>();

                //try
                //{
                //    await dataContext.Database.MigrateAsync();
                //    await SeedingDataInCarvoDbContext.SeedingData(dataContext);

                 
                //}
                //catch (Exception ex)
                //{
                //    var logger = loggerFactory.CreateLogger<Program>();
                //    logger.LogError(ex, "There was an error during migration or seeding.");
                //}
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // شغّل الفورم من DI
            var loginFrom = host.Services.GetRequiredService<LoginForm>();
            var adminCategoriesForm = host.Services.GetRequiredService<AdminCategoriesForm>();
            var adminCustomersForm = host.Services.GetRequiredService<AdminCustomersForm>();
            var adminEmplyeeForm = host.Services.GetRequiredService<AdminEmployeesForm>();
            var adminInvoicesForm = host.Services.GetRequiredService<AdminInvoicesForm>();
            var adminProductsForm = host.Services.GetRequiredService<AdminProductsForm>();
            var adminSuppliersForm = host.Services.GetRequiredService<AdminSuppliersForm>();
            var alertIncompleteInformationForm = host.Services.GetRequiredService<AlertIncompleteInformationForm>();
            var alertSelectAndDeleteForm = host.Services.GetRequiredService<AlertSelectAndDeleteForm>();
            var dashboardForm = host.Services.GetRequiredService<DashboardForm>();
            var deleteAlertForm = host.Services.GetRequiredService<DeleteAlertForm>();
            var homeDashboardForm = host.Services.GetRequiredService<HomeDashboardForm>();
            var invoiceForm = host.Services.GetRequiredService<InvoiceForm>();
            var invoiceTypeForm = host.Services.GetRequiredService<InvoiceTypeForm>();
            var mainWindowFrom = host.Services.GetRequiredService<MainWindowFrom>();
            var repairInvoiceForm = host.Services.GetRequiredService<RepairInvoiceForm>();
            var salesInvoiceForm = host.Services.GetRequiredService<SalesInvoiceForm>();
            var updateAlertForm = host.Services.GetRequiredService<UpdateAlertForm>();
            var vehicleDashboardForm = host.Services.GetRequiredService<VehicleDashboardForm>();
            var paidSalesInvoiceForm = host.Services.GetRequiredService<PaidSalesInvoiceForm>();

            var employeeDashboardForm = host.Services.GetRequiredService<EmployeeDashboardForm>();






            var service = host.Services.GetRequiredService<ICategoryService>();
            var vehicle = host.Services.GetRequiredService<IVehicleService>();
            var customerService = host.Services.GetRequiredService<ICustomerService>();

            Application.Run(mainWindowFrom);
            //Application.Run(loginFrom);

            // Admin Region
            #region Admin Region
            //Application.Run(homeDashboardForm);       // home page

            //Application.Run(adminCategoriesForm);
            //Application.Run(adminCustomersForm);
            //Application.Run(adminEmplyeeForm);
            //Application.Run(adminInvoicesForm);
            //Application.Run(adminProductsForm);
            //Application.Run(adminSuppliersForm);
            //Application.Run(vehicleDashboardForm);
            //Application.Run(dashboardForm);           // reports page
            #endregion


            // Employee Region
            #region Employee Region
            //Application.Run(employeeDashboardForm);   // home page

            //Application.Run(adminCustomersForm);
            //Application.Run(vehicleDashboardForm);

            //Application.Run(invoiceTypeForm);
            //Application.Run(repairInvoiceForm);
            //Application.Run(salesInvoiceForm);
            //Application.Run(paidSalesInvoiceForm);

            //Application.Run(invoiceForm);             // invoice should be printed

            //Application.Run(adminInvoicesForm);

            #endregion

            //Application.Run(customerDashboardForm);
            //Application.Run(updateAlertForm);                 // after update 
            //Application.Run(alertIncompleteInformationForm);  // if any field is missing
            //Application.Run(alertSelectAndDeleteForm);      
            //Application.Run(deleteAlertForm);                 // after delete
             


        }
    }
}