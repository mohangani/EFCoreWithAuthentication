using EFCoreApi.Models.DbModels;
using Microsoft.EntityFrameworkCore;

namespace EFCoreApi.Fluent_Validations
{
    public class ImageValidations : IValidation
    {
        public void AppendValidations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>().HasKey(x => x.Id);
            modelBuilder.Entity<Image>().Property(x => x.Url).IsRequired();
            modelBuilder.Entity<Image>().Property(x => x.Type).IsRequired();
        }
    }
}
