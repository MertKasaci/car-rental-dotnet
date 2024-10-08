using CarRental.Entities.Models;
using CarRental.Repositories.Contracts;
using CarRental.Repositories.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.Concretes
{
    public class LocationRepository : RepositoryBase<Location>, ILocationRepository
    {
        public LocationRepository(CarRentalContext context) : base(context)
        {
        }

        public void CreateLocation(Location location) =>
            Create(location);
        
        public void DeleteLocation(Location location) =>
            Delete(location);


        public async Task<IEnumerable<Location>> GetAllLocationsAsync(bool isTraceable) =>
            await FindAll(isTraceable)
            .Include(l => l.Address)
            .OrderBy(l => l.Id)
            .ToListAsync();

        public async Task<Location> GetLocationByIdAsync(Guid id, bool isTraceable) =>
            await FindByCondition((l => l.Id == id), isTraceable)
            .Include(l => l.Address)
            .FirstOrDefaultAsync();
        

        public void UpdateLocation(Location location) =>
            Update(location);
        
    }
}
