using EFCoreApi.Models.InputModels;
using EFCoreApi.Models.OutputModels;

namespace EFCoreApi.Infrastructure
{
    public interface ILogin
    {
        TokenDto Authenticate(LoginDto input);
    }
}