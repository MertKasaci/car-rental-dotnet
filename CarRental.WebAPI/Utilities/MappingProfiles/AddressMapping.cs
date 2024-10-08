using AutoMapper;
using CarRental.Entities.DataTransferObjects.AddressDTOs;
using CarRental.Entities.Models;

namespace CarRental.WebAPI.Utilities.MappingProfiles
{
    public class AddressMapping : Profile
    {
        public AddressMapping()
        {
            CreateMap<CreateAddressRequestDto, Address>();
            CreateMap<UpdateAddressRequestDto, Address>();
            CreateMap<Address, GetAddressResponseDto>();
        }
    }
}
