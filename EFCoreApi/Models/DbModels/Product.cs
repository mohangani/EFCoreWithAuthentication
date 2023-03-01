using EFCoreApi.Controllers;
using System.Collections.Generic;

namespace EFCoreApi.Models.DbModels
{
    public class Product : IDbModel
    {

        [SwaggerIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public List<Image> ImageUrl { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }
        public int SizeId { get; set; }
        [SwaggerIgnore]
        public Size Size { get; set; }
        public int SellerId { get; set; }
        [SwaggerIgnore]
        public Seller Seller { get; set; }
        [SwaggerIgnore]
        public ProductType ProductType { get; set; }
        public int PrdTypeId { get; set; }
        [SwaggerIgnore]
        public bool? IsActive { get; set; } = true;
        [SwaggerIgnore]
        public Cart Cart { get; set; }
    }
}
