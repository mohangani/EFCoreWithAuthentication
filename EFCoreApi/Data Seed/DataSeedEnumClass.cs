using System;

namespace EFCoreApi.Data_Seed
{
    public class DataSeedEnumClass<T> where T : Enum
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
