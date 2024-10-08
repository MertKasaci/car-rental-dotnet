using CarRental.Entities.Models;
using CarRental.Entities.RequestFeatures;
using CarRental.Repositories.Contracts;
using CarRental.Repositories.EFCore;
using CarRental.Repositories.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.Concretes
{
    public class CampaignRepository : RepositoryBase<Campaign>, ICampaignRepository
    {
        public CampaignRepository(CarRentalContext context) : base(context)
        {
        }

        public void CreateCampaign(Campaign campaign) =>
            Create(campaign);
        

        public void DeleteCampaign(Campaign campaign) =>
            Delete(campaign);


        public async Task<PagedList<Campaign>> GetAllCampaignsAsync(CampaignParameters campaignParameters, bool isTraceable)
        {
            var campaigns = await FindAll(isTraceable)
             .Sort(campaignParameters.OrderBy)
             .ToListAsync();

            return PagedList<Campaign>
                   .ToPagedList(campaigns,
                   campaignParameters.PageNumber,
                   campaignParameters.PageSize);

        }

        public async Task<IEnumerable<Campaign>> GetAvailableCampaignsForUserAsync(IEnumerable<Guid> userCampaignIds, bool isTraceable) =>
            await FindByCondition((c => !userCampaignIds.Contains(c.Id)), isTraceable)
            .ToListAsync();
        

        public async Task<Campaign> GetCampaignByIdAsync(Guid id, bool isTraceable) =>
            await FindByCondition((c => c.Id == id), isTraceable)
            .FirstOrDefaultAsync();
        

        public void UpdateCampaign(Campaign campaign) =>
            Update(campaign);
        
    }
}
