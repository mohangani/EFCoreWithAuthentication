using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Models.DbModels
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public List<Image> ImageUrl { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }
        public Size Size { get; set; }
        public Seller Seller { get; set; }
        public ProductType ProductType { get; set; }
        public bool IsActive { get; set; }
    }
}
