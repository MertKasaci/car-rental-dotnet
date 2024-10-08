using AutoMapper;
using CarRental.Entities.DataTransferObjects.LocationDTOs;
using CarRental.Entities.Models;
using CarRental.Repositories.Contracts;
using CarRental.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Concretes
{
    public class LocationService : ILocationService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public LocationService(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<GetLocationResponseDto> CreateLocationAsync(CreateLocationRequestDto createLocationRequestDto)
        {
            if (createLocationRequestDto is null)
                throw new ArgumentNullException(nameof(createLocationRequestDto));

            var location = _mapper.Map<Location>(createLocationRequestDto);

            _manager.Location.CreateLocation(location);

            await _manager.SaveAsync();

            var locationResponse = _mapper.Map<GetLocationResponseDto>(location);

            return locationResponse;
        }

        public async Task DeleteLocationAsync(Guid id, bool isTraceable)
        {
            var entity = await _manager.Location.GetLocationByIdAsync(id, isTraceable);

            if (entity is null)
                throw new Exception($"Location with id:{id} could not found");

            _manager.Location.DeleteLocation(entity);
            await _manager.SaveAsync();
        }

        public async Task<IEnumerable<GetLocationResponseDto>> GetAllLocationsAsync(bool isTraceable)
        {
            var locations = await _manager.Location.GetAllLocationsAsync(isTraceable);

            var locationsResponse = _mapper.Map<IEnumerable<GetLocationResponseDto>>(locations);

            return locationsResponse;
        }

        public async Task<GetLocationResponseDto> GetLocationByIdAsync(Guid id, bool trackChanges)
        {
            var location = await _manager.Location.GetLocationByIdAsync(id, trackChanges);

            if (location is null)
                throw new Exception($"Location with id:{id} could not found");

            var locationResponse = _mapper.Map<GetLocationResponseDto>(location);

            return locationResponse;
        }

        public async Task UpdateLocationAsync(Guid id, UpdateLocationRequestDto updateLocationRequestDto, bool trackChanges)
        {
            var entity = await _manager.Location.GetLocationByIdAsync(id, trackChanges);
            if (entity is null)
                throw new Exception($"Location with id:{id} could not found.");


            entity = _mapper.Map<Location>(updateLocationRequestDto);
            ;

            _manager.Location.UpdateLocation(entity);
            await _manager.SaveAsync();


        }
    }
}
