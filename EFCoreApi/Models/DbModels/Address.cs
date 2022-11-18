using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EFCoreApi.Models.DbModels
{
    public class Address
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        [JsonIgnore]
        public User User { get; set; }
        [JsonIgnore]
        public Seller Seller { get; set; }
    }
}
