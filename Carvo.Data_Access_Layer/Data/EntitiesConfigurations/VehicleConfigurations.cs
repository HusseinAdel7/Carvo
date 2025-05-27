using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carvo.Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Carvo.Data_Access_Layer.Data.EntitiesConfigurations
{
    public class VehicleConfigurations : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasKey(v => v.Id);

            builder.Property(v => v.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(v => v.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(v => v.Model)
                   .HasMaxLength(50);

            builder.Property(v => v.PlateNumber)
                   .HasMaxLength(20);


            builder.HasOne(v => v.Customer)
                   .WithMany() 
                   .HasForeignKey(v => v.CustomerId)
                   .OnDelete(DeleteBehavior.Cascade); 
        }
    }
}
