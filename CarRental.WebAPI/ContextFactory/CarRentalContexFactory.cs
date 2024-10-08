using CarRental.Repositories.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CarRental.WebAPI.ContextFactory
{
    public class CarRentalContexFactory : IDesignTimeDbContextFactory<CarRentalContext>
    {
        public CarRentalContext CreateDbContext(string[] args)
        {
            // configurationBuilder
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Development.json")
                .Build();


            //DbContextOptionsBuilder
            var builder = new DbContextOptionsBuilder<CarRentalContext>()
                .UseSqlServer(configuration.GetConnectionString("sqlConnection"),
                prj => prj.MigrationsAssembly("CarRental.WebAPI"));

            return new CarRentalContext(builder.Options);
        }
    }
}
