using EFCoreApi.Controllers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EFCoreApi.Models.DbModels
{
    public class Product : IDbModel
    {

        [JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public List<Image> ImageUrl { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }
        public int SizeId { get; set; }
        [JsonIgnore]
        public Size Size { get; set; }
        public int SellerId { get;  set; }
        [JsonIgnore]
        public Seller Seller { get; set; }
        [JsonIgnore]
        public ProductType ProductType { get; set; }
        public int PrdTypeId { get; set; }
        [JsonIgnore]
        public bool? IsActive { get; set; } = true;
        [JsonIgnore]
        public Cart Cart { get; set; }
    }
}
