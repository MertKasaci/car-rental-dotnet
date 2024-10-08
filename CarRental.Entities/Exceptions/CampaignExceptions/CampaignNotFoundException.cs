using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.Exceptions.CampaignExceptions
{
    public class CampaignNotFoundException : NotFoundException
    {
        public CampaignNotFoundException(Guid id) 
            : base($"The campaign with id : {id} could not found.")
        {
        }
    }
}
