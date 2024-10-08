using CarRental.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.DataTransferObjects.ModelDTOs
{
    public record UpdateModelRequestDto
    {
        [RequiredGuid]
        public Guid Id { get; init; }
        [Required]
        public string Name { get; init; }
        [Required]
        public Guid BrandId { get; init; }
        [Required]
        public int Capacity { get; init; }
        [Required]
        public FuelType FuelType { get; init; }
        [Required]
        public int LuggageCapacity { get; init; }
        [Required]
        public TransmissionType TransmissionType { get; init; }
    }
}
