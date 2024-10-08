﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.Exceptions.VehicleExceptions
{
    public class DailyPricesNotValidBadRequestException : BadRequestException
    {
        public DailyPricesNotValidBadRequestException() : base("Minimum veya Maksimum fiyat sıfırdan küçük olamaz.")
        {
        }
    }
}
