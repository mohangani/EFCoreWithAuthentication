using EFCoreApi.Models.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Fluent_Validations
{
    public class SizeValidations : IValidation
    {
        public void AppendValidations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Size>().HasKey(x => x.Id);
            modelBuilder.Entity<Size>().Property(x => x.ProductSize).IsRequired();
        }

    }
}
