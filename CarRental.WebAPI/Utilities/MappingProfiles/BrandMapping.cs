using AutoMapper;
using CarRental.Entities.DataTransferObjects.BrandDTOs;
using CarRental.Entities.Models;

namespace CarRental.WebAPI.Utilities.MappingProfiles
{
    public class BrandMapping : Profile
    {
        public BrandMapping()
        {
            CreateMap<CreateBrandRequestDto, Brand>();
            CreateMap<UpdateBrandRequestDto, Brand>();
            CreateMap<Brand, GetBrandResponseDto>();
        }
    }
}
