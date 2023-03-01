using System.Collections.Generic;

namespace EFCoreApi.Models.DbModels
{
    public class Size
    {
        [SwaggerIgnore]

        public int Id { get; set; }
        public float? Width { get; set; }
        public float? Height { get; set; }
        public string ProductSize { get; set; }

        [SwaggerIgnore]
        public ICollection<Product> Product { get; set; }
    }
}
