using Carvo.Business_Logic_Layer.IServices;
using Carvo.Business_Logic_Layer.Services;
using Carvo.Data_Access_Layer.Data.Context;
using Carvo.Data_Access_Layer.Entities;
using Carvo.Data_Access_Layer.Repository.GenericRepositories;
using Carvo.Data_Access_Layer.Repository.IGenericRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Carvo.Test_Console_Application
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<CarvoDbContext>(options =>
                        options.UseSqlServer("Server=db20389.public.databaseasp.net; Database=db20389; User Id=db20389; Password=Hussein1234@; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True;"));

                    services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));

                    services.AddScoped<ICategoryService, CategoryService>();
                })
                .Build();

            var service = host.Services.GetRequiredService<ICategoryService>();

            //// 1. Get All Categories
            //var allCategories = await service.GetAllCategoryAsync();
            //foreach (var item in allCategories)
            //{
            //    Console.WriteLine($"Category ID: {item.Id}, Name: {item.Name}");
            //}

            //**************************************************************************************

            //// 2. Get A Category By Id
            //var category = await service.GetCategoryByIdAsync(2);
            //Console.WriteLine($"Category ID: {category.Id}, Name: {category.Name}");

            //**************************************************************************************

            //// 3. Adding A Category
            //var newCategory = new Category
            //{
            //    Name = "Test Category",
            //    Description = "This is a test category."
            //};
            //await service.AddCategoryAsync(newCategory);

            //**************************************************************************************

            //// 4. Update a Category 
            //var firstCategory = allCategories.FirstOrDefault();
            //if (firstCategory != null)
            //{
            //    firstCategory.Name = "Updated Category Name";
            //    firstCategory.Description = "Updated description";

            //    var updatedCategory = await service.UpdateCategoryAsync(firstCategory);
            //    Console.WriteLine($"Updated Category => ID: {updatedCategory.Id}, Name: {updatedCategory.Name}");
            //}
            //else
            //{
            //    Console.WriteLine("No category found to update.");
            //}

            //**************************************************************************************

            // 5. Delete a Category 
            //await service.DeleteCategoryAsync(4);



        }
    }
}
