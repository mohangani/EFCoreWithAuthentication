using EFCoreApi.Models.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Fluent_Validations
{
    public class ImageValidations : IValidation
    {
        public void AppendValidations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>().HasKey(x => x.Id);
            modelBuilder.Entity<Image>().Property(x => x.Url).IsRequired();
            modelBuilder.Entity<Image>().Property(x => x.Type).IsRequired();
        }
    }
}
