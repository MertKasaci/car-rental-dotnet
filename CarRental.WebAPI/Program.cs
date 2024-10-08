
using CarRental.Presentation.ActionFilters;
using CarRental.Presentation.Controllers;
using CarRental.Services.Contracts.Logger;
using CarRental.WebAPI.Extensions;
using Microsoft.AspNetCore.Mvc;
using NLog;
using System.Text.Json.Serialization;


namespace CarRental.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.
               GetCurrentDirectory(), "/nlog.config"));

            builder.Services.AddControllers(options =>
            {
                options.Filters.Add(new ValidationFilterAttribute());
                options.RespectBrowserAcceptHeader = true;
                options.ReturnHttpNotAcceptable = true;
            })
                .AddApplicationPart(typeof(CarRental.Presentation.AssemblyReference).Assembly)
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                });

            builder.Services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            builder.Services.ConfigureSqlContext(builder.Configuration);
            builder.Services.RegisterRepositories();
            builder.Services.ConfigureRepositoryManager();
            builder.Services.ConfigureServiceManager();
            builder.Services.RegisterServices();
            builder.Services.ConfigureLoggerService();
            builder.Services.AddAutoMapper(typeof(Program));
            builder.Services.ConfigureActionFilters();
            builder.Services.ConfigureCors();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.ConfigureIdentity();
            builder.Services.ConfigureJWT(builder.Configuration);

            var app = builder.Build();

            var logger = app.Services.GetRequiredService<ILoggerService>();
            app.ConfigureExceptionHandler(logger);

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCors("CorsPolicy");

            app.UseAuthentication();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();

            
        }
    }
}
