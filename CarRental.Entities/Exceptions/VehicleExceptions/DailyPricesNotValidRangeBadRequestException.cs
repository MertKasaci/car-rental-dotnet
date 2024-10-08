using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.Exceptions.VehicleExceptions
{
    public class DailyPricesNotValidRangeBadRequestException : BadRequestException
    {
        public DailyPricesNotValidRangeBadRequestException() : base("Minimum fiyat , maksimum fiyattan fazla olamaz. ")
        {

        }
    }
}
