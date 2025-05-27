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
    public class InvoiceConfigurations : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Id).ValueGeneratedOnAdd();
            builder.Property(i => i.InvoiceNumber).IsRequired().HasMaxLength(100);
            builder.Property(i => i.RepairAmount).HasColumnType("decimal(18,2)");
            builder.Property(i => i.SaleAmount).HasColumnType("decimal(18,2)");
            builder.Property(i => i.InvoiceDate).IsRequired();

            builder.Property(i => i.InvoiceType).IsRequired();

            builder.HasOne(i => i.Customer)
                   .WithMany()
                   .HasForeignKey(i => i.CustomerId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(i => i.User)
                   .WithMany()
                   .HasForeignKey(i => i.UserId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
