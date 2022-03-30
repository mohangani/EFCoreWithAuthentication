using EFCoreApi.Infrastructure;
using EFCoreApi.Middlewares;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Extentions
{
    public static class ServiceCollectionExtention
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            services.AddTransient<ShopperStopDbContext, ShopperStopDbContext>();
            services.AddTransient<ExceptionMiddleWare>();
            services.AddSingleton<IToken,Token>();
            services.AddSingleton<ILogin, Login>();

            return services;
        }
    }
}
