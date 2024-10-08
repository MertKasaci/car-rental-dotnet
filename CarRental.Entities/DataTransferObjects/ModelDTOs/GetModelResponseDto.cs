using CarRental.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.DataTransferObjects.ModelDTOs
{
    public record GetModelResponseDto
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public int Capacity { get; init; }
        public FuelType FuelType { get; init; }
        public int LuggageCapacity { get; init; }
        public TransmissionType TransmissionType { get; init; }
    }
}
