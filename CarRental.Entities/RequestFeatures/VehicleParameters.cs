using CarRental.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.RequestFeatures
{
    public class VehicleParameters : RequestParameters
    {
        public decimal? MinDailyPrice { get; set; }
        public decimal? MaxDailyPrice { get; set; } 
        public int? Year { get; set; } 
        public VehicleColor? Color { get; set; }
        public VehicleStatus? Status { get; set; }


        public VehicleParameters()
        {
            OrderBy = "id";
        }



        public bool ValidDailyPrices()
        {
            if ((MinDailyPrice.HasValue && MinDailyPrice.Value < 0) || (MaxDailyPrice.HasValue && MaxDailyPrice.Value < 0))
            {
                return false;
            }
            return true;
        }

        public bool ValidDailyPriceRanges()
        {
                    
            if ((MinDailyPrice.HasValue && MaxDailyPrice.HasValue))
                return MinDailyPrice.Value <= MaxDailyPrice.Value;

            return true;
        }

        
        

    }
}
