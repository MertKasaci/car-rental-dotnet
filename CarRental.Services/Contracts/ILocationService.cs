using CarRental.Entities.DataTransferObjects.LocationDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Contracts
{
    public interface ILocationService
    {
        Task<IEnumerable<GetLocationResponseDto>> GetAllLocationsAsync(bool isTraceable);
        Task<GetLocationResponseDto> GetLocationByIdAsync(Guid id, bool isTraceable);
        Task<GetLocationResponseDto> CreateLocationAsync(CreateLocationRequestDto createLocationRequestDto);
        Task UpdateLocationAsync(Guid id, UpdateLocationRequestDto updateLocationRequestDto, bool isTraceable);
        Task DeleteLocationAsync(Guid id, bool isTraceable);
    }
}
