using EFCoreApi.Models.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Data_Seed
{
    public class RoleDataSeed : IDataSeed
    {
        public ModelBuilder SeedData(ModelBuilder modelBuilder)
        {
            var list = new List<Role>
            {
                new Role(){RoleId=1, RoleName="Admin"},
                new Role(){RoleId=2, RoleName="User"}
            };
            modelBuilder.Entity<Role>().HasData(list);

            return modelBuilder;
        }
    }
}
