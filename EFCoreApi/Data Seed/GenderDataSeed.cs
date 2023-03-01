using EFCoreApi.Models.DbModels;
using Microsoft.EntityFrameworkCore;

namespace EFCoreApi.Data_Seed
{
    public class GenderDataSeed : DataSeed
    {
        public override ModelBuilder SeedData(ModelBuilder modelBuilder) => SeedData<Gender, GenderType>(modelBuilder);


        //{
        //    //var list = Enum.GetValues(typeof(GenderType)).Cast<GenderType>().Select(x =>
        //    //new Gender { Name = x.ToString(), Id = x });
        //    //modelBuilder.Entity<Gender>().HasData(list);
        //    //return modelBuilder;
        //}
    }
}
