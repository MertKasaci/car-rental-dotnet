using CarRental.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.RequestFeatures
{
    public class ModelParameters : RequestParameters
    {
        public int? Capacity { get; set; } 
        public FuelType? FuelType { get; set; }
        public int? LuggageCapacity { get; set; }
        public TransmissionType? TransmissionType { get; set; }
    }
}
