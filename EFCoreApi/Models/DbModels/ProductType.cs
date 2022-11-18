using EFCoreApi.Data_Seed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EFCoreApi.Models.DbModels
{

    public class ProductType : DataSeedEnumClass<ProductEnum>
    {
        //    public ProductEnum Id { get; set; }
        //    public string Name { get; set; }

        [JsonIgnore]
        public ICollection<Product> Product { get; set; }
    }
    public enum ProductEnum : int
    {
        Computer = 1,
        Laptop = 2,
        KeyBords = 3,
        Speakers = 4,
        HeadPhones = 5,
        Chrgers = 6,
        PowerCables = 7,
        Tv = 8,
        Shoes = 9,
        Mobiles = 10,
        chairs = 11,
        Fridge = 12,
        WashingMachine = 13,
        Clothes = 14,
        Grinder = 15,
        Mixer = 16,
    }
}
