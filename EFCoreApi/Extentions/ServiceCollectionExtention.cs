using EFCoreApi.Infrastructure;
using EFCoreApi.Middlewares;
using Microsoft.Extensions.DependencyInjection;

namespace EFCoreApi.Extentions
{
    public static class ServiceCollectionExtention
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<ShopperStopDbContext, ShopperStopDbContext>();
            services.AddSingleton<ExceptionMiddleWare>();
            services.AddScoped<IToken, Token>();
            services.AddScoped<ILogin, Login>();

            return services;
        }
    }
}
