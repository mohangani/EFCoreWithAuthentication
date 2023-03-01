using EFCoreApi.Models.DbModels;
using Microsoft.EntityFrameworkCore;

namespace EFCoreApi.Fluent_Validations
{
    public class SizeValidations : IValidation
    {
        public void AppendValidations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Size>().HasKey(x => x.Id);
            modelBuilder.Entity<Size>().Property(x => x.ProductSize).IsRequired();
        }

    }
}
