using EFCoreApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EFCoreApi.Models.DbModels
{
    public class Seller : IDbModel
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public bool? IsActive { get; set; }

        [JsonIgnore]
        public ICollection<Product> Product { get; set; }
    }
}
