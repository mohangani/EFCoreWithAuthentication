using Microsoft.EntityFrameworkCore;

namespace EFCoreApi.Fluent_Validations
{
    public interface IValidation
    {
        void AppendValidations(ModelBuilder modelBuilder);
    }
}
