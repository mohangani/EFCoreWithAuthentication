using EFCoreApi.Fluent_Validations;
using EFCoreApi.Models;
using EFCoreApi.Models.DbModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi
{
    public class ShopperStopDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Gender> Genders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Server=localhost;Database=ShopperStop;Trusted_Connection=True;")
                              .LogTo(Console.WriteLine,LogLevel.Information);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.AppendValidations<User>()
                .AppendValidations<Address>()
                .SeedData<Gender>();
        }
    }
}
