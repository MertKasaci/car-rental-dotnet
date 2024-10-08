using CarRental.Entities.Enums;
using CarRental.Entities.Models;
using CarRental.Entities.RequestFeatures;
using CarRental.Repositories.Contracts;
using CarRental.Repositories.EFCore;
using CarRental.Repositories.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.Concretes
{
    public class VehicleRepository : RepositoryBase<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(CarRentalContext context) : base(context)
        {
        }

        public void CreateVehicle(Vehicle vehicle) =>
            Create(vehicle);



        public void DeleteVehicle(Vehicle vehicle) =>
            Create(vehicle);


        public async Task<PagedList<Vehicle>> GetAllVehiclesAsync(VehicleParameters vehiclesParameters , bool isTraceable)
        {
          var vehicles = await FindAll(isTraceable)
           .FilterVehicles(
             vehiclesParameters.MinDailyPrice,
             vehiclesParameters.MaxDailyPrice,
             vehiclesParameters.Year,
             vehiclesParameters.Color,
             vehiclesParameters.Status)
           .Sort(vehiclesParameters.OrderBy)
           .Include(v => v.Model)
           .Include(v => v.Reservations)
           .ThenInclude(r => r.Review)
           .Include(v => v.Reservations)
           .ThenInclude(r => r.User)
           .ToListAsync();

            return PagedList<Vehicle>
                   .ToPagedList(vehicles,
                   vehiclesParameters.PageNumber,
                   vehiclesParameters.PageSize);

        }
           

        public async Task<IEnumerable<Vehicle>> GetAllVehiclesByDetailsAsync(bool isTraceable) =>
            await FindAll(isTraceable)
            .OrderBy(v => v.Id)
            .Include(v => v.Model)
            .ToListAsync();


        public async Task<Vehicle> GetVehicleByIdAsync(Guid id, bool isTraceable) =>
            await FindByCondition((v => v.Id == id), isTraceable)
            .Include(v => v.Model)
            .Include(v => v.Reservations)
            .ThenInclude(r => r.Review)
            .Include(v => v.Reservations)
            .ThenInclude(r => r.User)
            .FirstOrDefaultAsync();
        

        public void UpdateVehicle(Vehicle vehicle) =>
            Update(vehicle);    
           
    }
}
