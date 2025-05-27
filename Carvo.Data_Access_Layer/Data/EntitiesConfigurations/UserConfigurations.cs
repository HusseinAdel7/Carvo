using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Carvo.Data_Access_Layer.Entities.Users;

namespace Carvo.Data_Access_Layer.Data.EntitiesConfigurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(u => u.UserName)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.Property(u => u.Password)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.Property(u => u.Email)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.Property(u => u.Role)
                   .IsRequired();

           
        }
    }
}
