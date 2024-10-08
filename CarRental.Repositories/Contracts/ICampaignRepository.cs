using CarRental.Entities.Models;
using CarRental.Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.Contracts
{
    public interface ICampaignRepository : IRepositoryBase<Campaign>
    {
        Task<PagedList<Campaign>> GetAllCampaignsAsync(CampaignParameters campaignParameters, bool isTraceable);
        Task<IEnumerable<Campaign>> GetAvailableCampaignsForUserAsync(IEnumerable<Guid> userCampaignIds,bool isTraceable);
        Task<Campaign> GetCampaignByIdAsync(Guid id, bool isTraceable);
        void CreateCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
    }
}
