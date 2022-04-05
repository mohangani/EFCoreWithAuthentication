using EFCoreApi.Models.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Fluent_Validations
{
    public class RoleValidations : IValidation
    {
        public void AppendValidations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasKey(x=>x.Id);
            modelBuilder.Entity<Role>().Property(x=>x.RoleName).IsRequired().HasMaxLength(16);
        }
    }
}
