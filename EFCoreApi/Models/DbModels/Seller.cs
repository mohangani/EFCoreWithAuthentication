using EFCoreApi.Controllers;
using System.Collections.Generic;

namespace EFCoreApi.Models.DbModels
{
    public class Seller : IDbModel
    {
        [SwaggerIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        [SwaggerIgnore]
        public int AddressId { get; set; }
        public Address Address { get; set; }
        [SwaggerIgnore]
        public bool? IsActive { get; set; } = true;

        [SwaggerIgnore]
        public ICollection<Product> Product { get; set; }
    }
}
