﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EFCoreApi.Data_Seed
{
    public abstract class DataSeed : IDataSeed
    {
        public abstract ModelBuilder SeedData(ModelBuilder modelBuilder);

        public virtual ModelBuilder SeedData<T, A>(ModelBuilder modelBuilder) where T : DataSeedEnumClass<A>, new() where A : Enum
        {
            var list = Enum.GetValues(typeof(A)).Cast<int>().Select(x =>
            new T { Name = x.ToString(), Id = x });
            modelBuilder.Entity<T>().HasData(list);
            return modelBuilder;
        }

    }
}
