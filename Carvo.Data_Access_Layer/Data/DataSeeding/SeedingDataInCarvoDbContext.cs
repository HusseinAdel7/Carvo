using System.Text.Json;
using Carvo.Data_Access_Layer.Data.Context;
using Carvo.Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carvo.Data_Access_Layer.DataSeeding
{
    public static class SeedingDataInCarvoDbContext
    {
        public async static Task SeedingData(CarvoDbContext _carvoDbContext)
        {
            //await SeedEntitiesAsync<Demo>(_carvoDbContext, _carvoDbContext.Demos, "Demo.json");
        }

        private static async Task SeedEntitiesAsync<T>(CarvoDbContext dbContext, DbSet<T> dbSet, string fileName) where T : class
        {
            if (!await dbSet.AnyAsync())
            {
                //var filePath = Path.Combine("..", "Carvo.Data_Access_Layer", "Data", "DataSeeding", fileName);
                var currentDirectory = Directory.GetCurrentDirectory();
                var filePath = Path.Combine(currentDirectory, "Data", "DataSeeding", fileName);

                if (File.Exists(filePath))
                {
                    var jsonData = await File.ReadAllTextAsync(filePath);
                    var entities = JsonSerializer.Deserialize<List<T>>(jsonData);
                    if (entities is not null && entities.Count > 0)
                    {
                        await dbSet.AddRangeAsync(entities);
                        await dbContext.SaveChangesAsync();
                    }
                }
            }
        }
    }
}
