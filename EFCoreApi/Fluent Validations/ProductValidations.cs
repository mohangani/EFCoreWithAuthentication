using EFCoreApi.Models.DbModels;
using Microsoft.EntityFrameworkCore;

namespace EFCoreApi.Fluent_Validations
{
    public class ProductValidations : IValidation
    {
        public void AppendValidations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(x => x.Id);
            modelBuilder.Entity<Product>().Property(x => x.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Product>().Property(x => x.Price).IsRequired();
            modelBuilder.Entity<Product>().Property(x => x.Color).IsRequired().HasMaxLength(16);
            modelBuilder.Entity<Product>().Property(x => x.Description).IsRequired().HasMaxLength(1000);
            modelBuilder.Entity<Product>().Property(x => x.IsActive).HasDefaultValue(true);
            modelBuilder.Entity<Product>().HasOne(x => x.Size).WithMany(x => x.Product).HasForeignKey(x => x.SizeId);
            modelBuilder.Entity<Product>().HasOne(x => x.Seller).WithMany(x => x.Product).HasForeignKey(x => x.SellerId);
            modelBuilder.Entity<Product>().HasOne(x => x.ProductType).WithMany(x => x.Product).HasForeignKey(x => x.PrdTypeId);
        }
    }
}
