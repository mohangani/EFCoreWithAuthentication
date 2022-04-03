using EFCoreApi.Models.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Data_Seed
{
    public class RoleDataSeed : DataSeed
    {
        public override ModelBuilder SeedData(ModelBuilder modelBuilder)
        {
            var list = new List<Role>
            {
                new Role(){RoleId=1, RoleName="Admin"},
                new Role(){RoleId=2, RoleName="User"},
                new Role(){RoleId=3, RoleName="Guest"}
            };
            modelBuilder.Entity<Role>().HasData(list);

            return modelBuilder;
        }
    }
}
