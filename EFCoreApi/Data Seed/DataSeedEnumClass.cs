using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Data_Seed
{
    public class DataSeedEnumClass<T> where T: Enum 
    {
        public T Id { get; set; }
        public string Name { get; set; }
    }
}
