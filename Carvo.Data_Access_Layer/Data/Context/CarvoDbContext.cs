using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Carvo.Data_Access_Layer.Entities;
using Carvo.Data_Access_Layer.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace Carvo.Data_Access_Layer.Data.Context
{
    public class CarvoDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceProduct> InvoiceProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=db20389.public.databaseasp.net; Database=db20389; User Id=db20389; Password=Hussein1234@; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True; ")
                          .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
        public CarvoDbContext(DbContextOptions<CarvoDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
          
        }
       

    }
}
