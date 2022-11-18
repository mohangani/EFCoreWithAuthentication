using EFCoreApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EFCoreApi.Models.DbModels
{
    public class Cart :IDbModel
    {
        [JsonIgnore]
        public int Id { get; set; }

        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        [JsonIgnore]
        public User User { get; set; }
        [JsonIgnore]
        public Product Product { get; set; }

    }
}
