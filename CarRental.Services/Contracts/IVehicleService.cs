
using CarRental.Entities.DataTransferObjects.BrandDTOs;
using CarRental.Entities.DataTransferObjects.VehicleDTOs;
using CarRental.Entities.Enums;
using CarRental.Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Contracts
{
    public interface IVehicleService
    {
        Task<(IEnumerable<GetVehicleByDetailsResponseDto> vehicles, MetaData metaData)> GetAllVehiclesAsync(VehicleParameters vehicleParameters, bool isTraceable);
        Task<IEnumerable<GetVehicleByDetailsResponseDto>> GetAllVehiclesByDetailsAsync(bool isTraceable);
        Task<GetVehicleByDetailsResponseDto> GetVehicleByIdAsync(Guid id, bool isTraceable);
        Task<GetVehicleResponseDto> CreateVehicleAsync(CreateVehicleRequestDto createVehicleRequestDto);
        Task UpdateVehicleAsync(Guid id, UpdateVehicleRequestDto updateVehicleRequestDto, bool isTraceable);
        Task DeleteVehicleAsync(Guid id, bool isTraceable);

    }
}
