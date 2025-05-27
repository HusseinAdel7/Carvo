using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carvo.Data_Access_Layer.Entities.Users;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Carvo.Data_Access_Layer.Data.EntitiesConfigurations
{
    public class SupplierConfigurations : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(s => s.Name)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.Property(s => s.PhoneNumber)
                   .IsRequired()
                   .HasMaxLength(11);

            builder.Property(s => s.Address)
                   .HasMaxLength(100);

            builder.Property(s => s.ComapayName)
                   .HasMaxLength(50);

            builder.Property(s => s.RemainingBalance)
                   .IsRequired();
  
        }
    }
}
