using EFCoreApi.Models.DbModels;

namespace EFCoreApi.Infrastructure
{
    public interface IToken
    {
        string Create(User user);
    }   
}