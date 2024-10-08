using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.DataTransferObjects.CampaignDTOs
{
    public record CreateCampaignRequestDto
    {
        public string Title { get; init; }
        public string Description { get; init; }
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }
        public double DiscountPercentage { get; init; }
        public bool IsActive { get; init; }
    }
}
