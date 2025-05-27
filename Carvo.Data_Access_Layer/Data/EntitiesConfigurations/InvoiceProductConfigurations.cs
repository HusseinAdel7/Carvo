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
    public class InvoiceProductConfigurations : IEntityTypeConfiguration<InvoiceProduct>
    {
        public void Configure(EntityTypeBuilder<InvoiceProduct> builder)
        {
            builder.HasKey(ip => ip.Id);

            builder.Property(ip => ip.Id).ValueGeneratedOnAdd();
            builder.Property(ip => ip.Quantity).IsRequired();

            builder.HasOne(ip => ip.Invoice)
                   .WithMany(i => i.InvoiceProducts)
                   .HasForeignKey(ip => ip.InvoiceId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ip => ip.Product)
                   .WithMany(p => p.InvoiceProducts)
                   .HasForeignKey(ip => ip.ProductId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
