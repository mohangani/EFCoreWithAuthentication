using EFCoreApi.Models.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Data_Seed
{
    public class GenderDataSeed : IDataSeed
    {
        public ModelBuilder SeedData(ModelBuilder modelBuilder)
        {
            var list = Enum.GetValues(typeof(GenderType)).Cast<GenderType>().Select(x =>
            new Gender { GenderName = x.ToString(), GenderId = x });
            modelBuilder.Entity<Gender>().HasData(list);
            return modelBuilder;
        }
    }
}
