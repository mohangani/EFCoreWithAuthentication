using EFCoreApi.Models.DbModels;
using Microsoft.EntityFrameworkCore;

namespace EFCoreApi.Fluent_Validations
{
    public class CartValidations : IValidation
    {
        public void AppendValidations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>().HasKey(x => x.Id);
            modelBuilder.Entity<Cart>().Property(x => x.Quantity).IsRequired();
            modelBuilder.Entity<Cart>().HasOne(x => x.User).WithOne(x => x.Cart).HasForeignKey<Cart>(x => x.UserId);
            modelBuilder.Entity<Cart>().HasOne(x => x.Product).WithOne(x => x.Cart).HasForeignKey<Cart>(x => x.ProductId);
        }
    }
}
