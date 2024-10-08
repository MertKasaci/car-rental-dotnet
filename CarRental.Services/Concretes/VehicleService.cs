using AutoMapper;
using CarRental.Entities.DataTransferObjects.BrandDTOs;
using CarRental.Entities.DataTransferObjects.VehicleDTOs;
using CarRental.Entities.Exceptions.VehicleExceptions;
using CarRental.Entities.Models;
using CarRental.Entities.RequestFeatures;
using CarRental.Repositories.Contracts;
using CarRental.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Concretes
{
    public class VehicleService : IVehicleService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public VehicleService(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<GetVehicleResponseDto> CreateVehicleAsync(CreateVehicleRequestDto createVehicleRequestDto)
        {
            if(createVehicleRequestDto is null)
                throw new ArgumentNullException(nameof(createVehicleRequestDto));

            var vehicle = _mapper.Map<Vehicle>(createVehicleRequestDto);

            _manager.Vehicle.CreateVehicle(vehicle);
            await _manager.SaveAsync();

            var vehicleResponse = _mapper.Map<GetVehicleResponseDto>(vehicle);  

            return vehicleResponse; 
        }

        public async Task DeleteVehicleAsync(Guid id, bool isTraceable)
        {
            var entity = await _manager.Vehicle.GetVehicleByIdAsync(id,isTraceable);
            
            if(entity is null )
                throw new ArgumentNullException(nameof(entity));

            _manager.Vehicle.DeleteVehicle(entity);
            await _manager.SaveAsync();


        }

        public async Task<(IEnumerable<GetVehicleByDetailsResponseDto> vehicles, MetaData metaData)> GetAllVehiclesAsync(VehicleParameters vehicleParameters, bool isTraceable)
            {

            if (!vehicleParameters.ValidDailyPrices())
                throw new DailyPricesNotValidBadRequestException();

            if (!vehicleParameters.ValidDailyPriceRanges())
                throw new DailyPricesNotValidRangeBadRequestException();


            var vehicleWithMetaData = await _manager
                .Vehicle
                .GetAllVehiclesAsync(vehicleParameters, isTraceable);

            var vehicleResponse = _mapper.Map<IEnumerable<GetVehicleByDetailsResponseDto>>(vehicleWithMetaData);


            return (vehicles : vehicleResponse, metaData : vehicleWithMetaData.MetaData);
        }


        public async Task<IEnumerable<GetVehicleByDetailsResponseDto>> GetAllVehiclesByDetailsAsync(bool isTraceable)
        {
            var vehicles = await _manager.Vehicle.GetAllVehiclesByDetailsAsync(isTraceable);
            
            var vehicleByDetailsResponse = _mapper.Map<IEnumerable<GetVehicleByDetailsResponseDto>>(vehicles);
            
            return vehicleByDetailsResponse;    
        }

        public async Task<GetVehicleByDetailsResponseDto> GetVehicleByIdAsync(Guid id, bool isTraceable)
        {
            var vehicle = await _manager.Vehicle.GetVehicleByIdAsync(id, isTraceable);

            if (vehicle is null)
                throw new Exception($"Vehicle with id:{id} could not found");

            var vehicleResponse = _mapper.Map<GetVehicleByDetailsResponseDto>(vehicle);

            return vehicleResponse;
        }

        public async Task UpdateVehicleAsync(Guid id, UpdateVehicleRequestDto updateVehicleRequestDto, bool isTraceable)
        {
            var entity = await _manager.Vehicle.GetVehicleByIdAsync(id, isTraceable);
            if (entity is null)
                throw new Exception($"Vehicle with id:{id} could not found.");


            entity = _mapper.Map<Vehicle>(updateVehicleRequestDto);
            ;

            _manager.Vehicle.UpdateVehicle(entity);
            await _manager.SaveAsync();
        }
    }
}
