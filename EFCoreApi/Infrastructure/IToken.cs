using EFCoreApi.Models.DbModels;
using EFCoreApi.Models.OutputModels;

namespace EFCoreApi.Infrastructure
{
    public interface IToken
    {
        TokenDto Create(User user);
    }   
}