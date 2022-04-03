using EFCoreApi.Models.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Data_Seed
{
    public class ProductTypeDataSeed : DataSeed
    {
        public override ModelBuilder SeedData(ModelBuilder modelBuilder) => SeedData<ProductType, ProductEnum>(modelBuilder);

        //public ModelBuilder SeedData(ModelBuilder modelBuilder)
        //{
        //    var list = Enum.GetValues(typeof(ProductEnum)).Cast<ProductEnum>().Select(x =>
        //    new ProductType { Name = x.ToString(), Id = x });
        //    modelBuilder.Entity<ProductType>().HasData(list);
        //    return modelBuilder;
        //}
    }
}
