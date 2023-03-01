using EFCoreApi.Data_Seed;
using EFCoreApi.Fluent_Validations;
using Microsoft.EntityFrameworkCore;
using System;

namespace EFCoreApi
{
    public static class ModelBuilderExtention
    {

        //public static void AppendValidations<T>(this ModelBuilder modelBuilder) where T : IValidation, new()
        //{
        //    var model = new T();
        //    model.AppendValidations(modelBuilder);
        //}

        public static ModelBuilder AppendValidations<T>(this ModelBuilder modelBuilder) where T : class
        {
            //Debugger.Launch();
            Type modeltype = Type.GetType($"EFCoreApi.Fluent_Validations.{typeof(T).Name}Validations");

            if (modeltype is null) return modelBuilder;
            var model = Activator.CreateInstance(modeltype);

            if (model is null) return modelBuilder;

            ((IValidation)model).AppendValidations(modelBuilder);
            return modelBuilder;
        }
        public static ModelBuilder SeedData<T>(this ModelBuilder modelBuilder) where T : class
        {
            Type modeltype = Type.GetType($"EFCoreApi.Data_Seed.{typeof(T).Name}DataSeed");

            if (modeltype is not null)
            {
                var model = Activator.CreateInstance(modeltype);
                if (model is not null)
                    ((DataSeed)model).SeedData(modelBuilder);
            }
            return modelBuilder;
        }
    }
}
