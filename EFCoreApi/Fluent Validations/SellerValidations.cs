using EFCoreApi.Models.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Fluent_Validations
{
    public class SellerValidations : IValidation
    {
        public void AppendValidations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Seller>().HasKey(x => x.Id);
            modelBuilder.Entity<Seller>().Property(x => x.Name).IsRequired().HasMaxLength(24);
            modelBuilder.Entity<Seller>().Property(x => x.IsActive).HasDefaultValue(true);
            modelBuilder.Entity<Seller>().HasOne(x => x.Address).WithOne(x=>x.Seller).HasForeignKey<Seller>(x => x.AddressId);
        }
    }
}
