using EFCoreApi.Models.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Fluent_Validations
{
    public class UserValidations : IValidation
    {
        public void AppendValidations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<User>().HasIndex(x => x.UserName).IsUnique();
            modelBuilder.Entity<User>().HasIndex(x => new { x.FirstName, x.LastName, x.Dob }).IsUnique();
            
            modelBuilder.Entity<User>().Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<User>().Property(x => x.LastName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<User>().Property(x => x.Dob).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.Email).IsRequired().HasMaxLength(160);
            modelBuilder.Entity<User>().Property(x => x.Phone).HasMaxLength(15);
            modelBuilder.Entity<User>().Property(x => x.UserName).IsRequired().HasMaxLength(15);
            modelBuilder.Entity<User>().Property(x => x.Password).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.Gender).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.IsActive).IsRequired();
            modelBuilder.Entity<User>().HasOne(x => x.Address).WithOne().HasForeignKey<User>(x=>x.AddressId);
            modelBuilder.Entity<User>().HasOne(x => x.Role).WithOne().HasForeignKey<User>(x=>x.RoleId);
        }
    }
}
