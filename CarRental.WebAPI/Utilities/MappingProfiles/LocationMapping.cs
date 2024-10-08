using AutoMapper;
using CarRental.Entities.DataTransferObjects.LocationDTOs;
using CarRental.Entities.Models;

namespace CarRental.WebAPI.Utilities.MappingProfiles
{
    public class LocationMapping : Profile
    {
        public LocationMapping()
        {
            CreateMap<CreateLocationRequestDto, Location>();
            CreateMap<UpdateLocationRequestDto, Location>();
            CreateMap<Location, GetLocationResponseDto>();
        }
        
    }
}
