using EFCoreApi.Models.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Fluent_Validations
{
    public class ProductValidations : IValidation
    {
        public void AppendValidations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(x => x.Id);
            modelBuilder.Entity<Product>().Property(x => x.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Product>().Property(x => x.Price).IsRequired();
            modelBuilder.Entity<Product>().Property(x => x.Color).IsRequired().HasMaxLength(16);
            modelBuilder.Entity<Product>().Property(x => x.Description).IsRequired().HasMaxLength(1000);
            modelBuilder.Entity<Product>().Property(x => x.IsActive).IsRequired().HasDefaultValue(true);
        }
    }
}
