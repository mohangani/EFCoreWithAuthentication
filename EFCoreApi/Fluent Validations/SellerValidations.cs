﻿using EFCoreApi.Models.DbModels;
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
            modelBuilder.Entity<Seller>().HasKey(x => x.SellerId);
            modelBuilder.Entity<Seller>().Property(x => x.Name).IsRequired().HasMaxLength(24);
            modelBuilder.Entity<Seller>().Property(x => x.IsActive).IsRequired().HasDefaultValue(true);
        }
    }
}