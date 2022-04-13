using EFCoreApi.Models.OutputModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EFCoreApi.Middlewares
{
    public class ExceptionMiddleWare : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                 await next(context);
            }
            catch (Exception ex)
            {
                var exception = new ExceptionModel
                {
                    StackTrace = ex.StackTrace,
                    ExceptionMessage = ex.Message,
                    InnerExceptionMessage = ex.InnerException
                };

                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json"; 

                await context.Response.WriteAsync(exception.ToString());
            }
        }
    }
}
