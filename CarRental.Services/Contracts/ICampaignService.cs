using CarRental.Entities.DataTransferObjects.CampaignDTOs;
using CarRental.Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Contracts
{
    public interface ICampaignService
    {
      Task<(IEnumerable<GetCampaignResponseDto> campaigns,MetaData metaData)> GetAllCampaignsAsync(CampaignParameters campaignParameters, bool isTraceable);
      Task<IEnumerable<GetCampaignResponseDto>> GetAvailableCampaignsForUserAsync(Guid userId,bool isTraceable);
      Task<GetCampaignResponseDto> GetCampaignByIdAsync(Guid id , bool isTraceable);
      Task<GetCampaignResponseDto> CreateCampaignAsync(CreateCampaignRequestDto createCampaignRequestDto);
      Task<GetCampaignResponseDto> AddCampaignToUserAsync(Guid userId, Guid campaignId);
      Task UpdateCampaignAsync(Guid id, UpdateCampaignRequestDto updateCampaignRequestDto, bool isTraceable);
      Task DeleteCampaignAsync(Guid id , bool isTraceable);
    }
}
