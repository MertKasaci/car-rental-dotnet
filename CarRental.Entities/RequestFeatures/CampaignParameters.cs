﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.RequestFeatures
{
    public class CampaignParameters : RequestParameters
    {
        public CampaignParameters()
        {
            OrderBy = "id";
        }
    }
}
