using CarRental.Entities.Enums;
using CarRental.Entities.Enums.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Presentation.Controllers
{
    [ApiController]
    [Route("api/enums")]
    public class EnumsController : ControllerBase
    {
        [HttpGet("vehicle-colors")]
        public IActionResult GetVehicleColors()
        {
            var values = default(VehicleColor).GetEnumValues();
            
            return Ok(values);
        }

        [HttpGet("vehicle-statuses")]
        public IActionResult GetVehicleStatuses()
        {
            var values = default(VehicleStatus).GetEnumValues();
            return Ok(values);
        }

        [HttpGet("fuel-types")]
        public IActionResult GetFuelTypes()
        {
            var values = default(FuelType).GetEnumValues();
            return Ok(values);
        }

        [HttpGet("transmission-types")]
        public IActionResult GetTransmissionTypes()
        {
            var values = default(TransmissionType).GetEnumValues();
            return Ok(values);
        }

        [HttpGet("payment-methods")]
        public IActionResult GetPaymentMethods()
        {
            var values = default(PaymentMethod).GetEnumValues();
            return Ok(values);
        }
        
        [HttpGet("cities")]
        public IActionResult GetCities()
        {
            var values = default(City).GetEnumValues();
            return Ok(values);
        }
    }

}
