using AutoMapper;
using CarRental.Entities.DataTransferObjects.CampaignDTOs;
using CarRental.Entities.Models;

namespace CarRental.WebAPI.Utilities.MappingProfiles
{
    public class CampaignMapping : Profile
    {
        public CampaignMapping()
        {
            CreateMap<CreateCampaignRequestDto, Campaign>();
            CreateMap<UpdateCampaignRequestDto, Campaign>();
            CreateMap<Campaign, GetCampaignResponseDto>();
        }
    }
}
