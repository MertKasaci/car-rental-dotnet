using AutoMapper;
using CarRental.Entities.DataTransferObjects.BrandDTOs;
using CarRental.Entities.DataTransferObjects.ModelDTOs;
using CarRental.Entities.Models;

namespace CarRental.WebAPI.Utilities.MappingProfiles
{
    public class ModelMapping : Profile
    {
        public ModelMapping()
        {
            CreateMap<CreateModelRequestDto, Model>();
            CreateMap<UpdateModelRequestDto, Model>();
            CreateMap<Model, GetModelResponseDto>();

        }
    }
}
