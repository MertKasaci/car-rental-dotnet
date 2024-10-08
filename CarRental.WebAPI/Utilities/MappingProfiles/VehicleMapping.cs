using AutoMapper;
using CarRental.Entities.DataTransferObjects.BrandDTOs;
using CarRental.Entities.DataTransferObjects.VehicleDTOs;
using CarRental.Entities.Models;
using CarRental.Entities.RequestFeatures;

namespace CarRental.WebAPI.Utilities.MappingProfiles
{
    public class VehicleMapping : Profile 
    {
        public VehicleMapping()
        {
            CreateMap<CreateVehicleRequestDto, Vehicle>();
            CreateMap<UpdateVehicleRequestDto, Vehicle>();
            CreateMap<Vehicle, GetVehicleResponseDto>();
            CreateMap<Vehicle, GetVehicleByDetailsResponseDto>();
        }
    }
}
