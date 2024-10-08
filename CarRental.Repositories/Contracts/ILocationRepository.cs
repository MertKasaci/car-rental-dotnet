using CarRental.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.Contracts
{
    public interface ILocationRepository : IRepositoryBase<Location>
    {
        Task<IEnumerable<Location>> GetAllLocationsAsync(bool isTraceable);
        Task<Location> GetLocationByIdAsync(Guid id, bool isTraceable);
        void CreateLocation(Location location);
        void UpdateLocation(Location location);
        void DeleteLocation(Location location);
    }
}
