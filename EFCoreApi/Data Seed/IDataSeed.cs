using Microsoft.EntityFrameworkCore;

namespace EFCoreApi.Data_Seed
{
    public interface IDataSeed
    {
        ModelBuilder SeedData(ModelBuilder modelBuilder);
    }
}
