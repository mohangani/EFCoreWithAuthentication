using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Data_Seed
{
    public interface IDataSeed
    {
        ModelBuilder SeedData(ModelBuilder modelBuilder);
    }
}
