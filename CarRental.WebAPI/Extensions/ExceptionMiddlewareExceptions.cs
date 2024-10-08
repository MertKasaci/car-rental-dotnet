using CarRental.Entities.Exceptions;
using CarRental.Entities.Models.ErrorModel;
using CarRental.Services.Contracts.Logger;
using Microsoft.AspNetCore.Diagnostics;

namespace CarRental.WebAPI.Extensions
{
    public static class ExceptionMiddlewareExceptions
    {
        public static void ConfigureExceptionHandler(this WebApplication app, ILoggerService logger)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.ContentType = "applicaton/json";

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature is not null)
                    {
                        context.Response.StatusCode = contextFeature.Error switch
                        {
                            NotFoundException => StatusCodes.Status404NotFound,
                            _ => StatusCodes.Status500InternalServerError,

                        };

                        logger.LogError($"Something went wrong:{contextFeature.Error.Message}");
                        await context.Response.WriteAsync(new ErrorDetails()
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = contextFeature.Error.Message
                        }.ToString());
                    }
                });
            });
        }

    }
}
