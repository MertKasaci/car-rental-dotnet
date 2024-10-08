using CarRental.Entities.Models;
using CarRental.Presentation.ActionFilters;
using CarRental.Repositories.Concretes;
using CarRental.Repositories.Contracts;
using CarRental.Repositories.EFCore;
using CarRental.Services.Concretes;
using CarRental.Services.Concretes.Logger;
using CarRental.Services.Contracts;
using CarRental.Services.Contracts.Logger;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace CarRental.WebAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CarRentalContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
        }
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<ICreditCardRepository, CreditCardRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<IModelRepository, ModelRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<IReservationRepository, ReservationRepository>();
            services.AddScoped<IReviewRepository,ReviewRepository>();
            services.AddScoped<IVehicleRepository, VehicleRepository>();
            services.AddScoped<ICampaignRepository, CampaignRepository>();
        }
        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddSingleton<ILoggerService, LoggerService>();
        public static void RegisterServices (this IServiceCollection services)
        {
            services.AddScoped<IBrandService, BrandService>();
            services.AddScoped<IModelService, ModelService>();
            services.AddScoped<IVehicleService, VehicleService>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<ICreditCardService, CreditCardService>();
            services.AddScoped<ILocationService, LocationService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IReservationService, ReservationService>();
            services.AddScoped<IReviewService, ReviewService>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICampaignService, CampaignService>();
        }
        public static void ConfigureServiceManager (this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
        }
        public static void ConfigureActionFilters(this IServiceCollection services)
        {
            services.AddScoped<ValidationFilterAttribute>();
            services.AddScoped<LogFilterAttribute>();
        }
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .WithExposedHeaders("X-Pagination")
                );
            });
        }
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentity<User,IdentityRole<Guid>>(o =>
            {
                o.Password.RequireDigit = true;
                o.Password.RequireLowercase = false;
                o.Password.RequireUppercase = false;
                o.Password.RequireNonAlphanumeric = false;
                o.Password.RequiredLength = 6;
                o.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<CarRentalContext>()
            .AddDefaultTokenProviders();
        }
        public static void ConfigureJWT(this IServiceCollection services,
            IConfiguration configuration)
        {
            var jwtSettings = configuration.GetSection("jwtSettings");
            var secretKey = jwtSettings["secretKey"];

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true, 
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = jwtSettings["validIssuer"],
                        ValidAudience = jwtSettings["validAudience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))

                      
                    };
                });
        }

    }
}
