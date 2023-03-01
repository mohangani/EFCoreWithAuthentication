using EFCoreApi.Models.DbModels;
using Microsoft.EntityFrameworkCore;

namespace EFCoreApi.Fluent_Validations
{
    public class BookDetailValidations : IValidation
    {
        public void AppendValidations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookDetail>().HasKey(x => x.Id);
        }
    }
}
