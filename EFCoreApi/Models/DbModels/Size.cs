using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EFCoreApi.Models.DbModels
{
    public class Size
    {
        [JsonIgnore]

        public int Id { get; set; }
        public float? Width { get; set; }
        public float? Height { get; set; }
        public string ProductSize { get; set; }

        [JsonIgnore]
        public ICollection<Product> Product { get; set; }
    }
}
