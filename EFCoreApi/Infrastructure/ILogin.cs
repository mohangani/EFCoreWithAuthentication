using EFCoreApi.Models.InputModels;

namespace EFCoreApi.Infrastructure
{
    public interface ILogin
    {
        string Authenticate(LoginDto input);
    }
}