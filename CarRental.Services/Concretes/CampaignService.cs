using AutoMapper;
using CarRental.Entities.DataTransferObjects.CampaignDTOs;
using CarRental.Entities.Exceptions.CampaignExceptions;
using CarRental.Entities.Exceptions.UserExceptions;
using CarRental.Entities.Models;
using CarRental.Entities.RequestFeatures;
using CarRental.Repositories.Concretes;
using CarRental.Repositories.Contracts;
using CarRental.Services.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Concretes
{
    public class CampaignService : ICampaignService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public CampaignService(IRepositoryManager manager, IMapper mapper, UserManager<User> userManager)
        {
            _manager = manager;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<GetCampaignResponseDto> AddCampaignToUserAsync(Guid userId, Guid campaignId)
        {
            var user = await _userManager.Users
                .Include(u => u.Campaigns)
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (user is null)
                throw new UserNotFoundException(userId);

            var campaign = await _manager
                .Campaign
                .GetCampaignByIdAsync(campaignId,false);

            if (campaign is null)
                throw new CampaignNotFoundException(campaignId);

            user.Campaigns.Add(campaign);
            await _manager.SaveAsync();

            return _mapper.Map<GetCampaignResponseDto>(campaign);

            
                
                
        }

        public async Task<GetCampaignResponseDto> CreateCampaignAsync(CreateCampaignRequestDto createCampaignRequestDto)
        {
            if(createCampaignRequestDto is null)
                throw new ArgumentNullException(nameof(createCampaignRequestDto));  

            var campaign = _mapper.Map<Campaign>(createCampaignRequestDto); 

            _manager.Campaign.Create(campaign);

            await _manager.SaveAsync();

            var campaignResponse = _mapper.Map<GetCampaignResponseDto>(campaign);   

            return campaignResponse;
        }

        public async Task DeleteCampaignAsync(Guid id, bool isTraceable)
        {
            var entity = await  _manager.Campaign.GetCampaignByIdAsync(id, isTraceable);

            if (entity is null)
                throw new Exception($"Campaign with id:{id} could not found");

            _manager.Campaign.Delete(entity);

            await _manager.SaveAsync();


        }

        public async Task<(IEnumerable<GetCampaignResponseDto> campaigns ,MetaData metaData)> GetAllCampaignsAsync(CampaignParameters campaignParameters ,bool isTraceable)
        {
            var campaignsWithMetaData = await _manager.Campaign.GetAllCampaignsAsync(campaignParameters ,isTraceable);

            var campaingsResponse = _mapper.Map<IEnumerable<GetCampaignResponseDto>>(campaignsWithMetaData); 
            
            return (campaigns : campaingsResponse,metaData: campaignsWithMetaData.MetaData);
        }

        public async Task<IEnumerable<GetCampaignResponseDto>> GetAvailableCampaignsForUserAsync(Guid userId, bool isTraceable)
        {
            var user = await _userManager.Users
                .Include(u => u.Campaigns)
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (user is null)
                throw new UserNotFoundException(userId);

            //all campaign ids that user have.
            var userCampaignIds = user.Campaigns.Select(c => c.Id);

            var availableCampaignsForUser = await _manager.Campaign.GetAvailableCampaignsForUserAsync(userCampaignIds, isTraceable);

            return _mapper.Map<IEnumerable<GetCampaignResponseDto>>(availableCampaignsForUser);


        }

        public async Task<GetCampaignResponseDto> GetCampaignByIdAsync(Guid id, bool isTraceable)
        {
            var campaign = await _manager.Campaign.GetCampaignByIdAsync(id, isTraceable);

            if (campaign is null)
                throw new Exception($"Campaing with id:{id} could not found");

            var campaignResponse = _mapper.Map<GetCampaignResponseDto>(campaign);

            return campaignResponse;


        }

        public async Task UpdateCampaignAsync(Guid id, UpdateCampaignRequestDto updateCampaignRequestDto, bool isTraceable)
        {
            var entity = await _manager.Campaign.GetCampaignByIdAsync(id, isTraceable);

            if (entity is null)
                throw new Exception($"Campaign with id:{id} could not found.");

            entity = _mapper.Map<Campaign>(updateCampaignRequestDto);

            _manager.Campaign.UpdateCampaign(entity);
            await _manager.SaveAsync();
        }
    }
}
