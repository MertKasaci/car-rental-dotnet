using CarRental.Entities.Models;
using CarRental.Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.Contracts
{
    public interface IVehicleRepository : IRepositoryBase<Vehicle>
    {
        Task<PagedList<Vehicle>> GetAllVehiclesAsync(VehicleParameters vehicleParameters, bool isTraceable);
        Task<IEnumerable<Vehicle>> GetAllVehiclesByDetailsAsync(bool isTraceable);
        Task<Vehicle> GetVehicleByIdAsync(Guid id, bool isTraceable);
        void CreateVehicle(Vehicle vehicle);
        void UpdateVehicle(Vehicle vehicle);
        void DeleteVehicle(Vehicle vehicle);
    }
}
