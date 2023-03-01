using EFCoreApi.Models.DbModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EFCoreApi.Data_Seed
{
    public class RoleDataSeed : DataSeed
    {
        public override ModelBuilder SeedData(ModelBuilder modelBuilder)
        {
            var list = new List<Role>
            {
                new Role(){Id=1, RoleName="Admin"},
                new Role(){Id=2, RoleName="User"},
                new Role(){Id=3, RoleName="Guest"}
            };
            modelBuilder.Entity<Role>().HasData(list);

            return modelBuilder;
        }
    }
}
