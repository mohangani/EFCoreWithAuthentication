namespace EFCoreApi.Infrastructure
{
    public interface IToken
    {
        string Create(string username);
    }
}