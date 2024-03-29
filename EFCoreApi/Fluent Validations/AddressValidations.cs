﻿using EFCoreApi.Models.DbModels;
using Microsoft.EntityFrameworkCore;

namespace EFCoreApi.Fluent_Validations
{
    public class AddressValidations : IValidation
    {
        public void AppendValidations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().HasKey(x => x.Id);
            modelBuilder.Entity<Address>().Property(x => x.Street).HasMaxLength(50);
            modelBuilder.Entity<Address>().Property(x => x.State).HasMaxLength(24);
            modelBuilder.Entity<Address>().Property(x => x.City).HasMaxLength(24);
            modelBuilder.Entity<Address>().Property(x => x.Pincode).HasMaxLength(16);
        }
    }
}
