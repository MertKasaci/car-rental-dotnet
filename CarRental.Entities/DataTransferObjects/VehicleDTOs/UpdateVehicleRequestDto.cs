using CarRental.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.DataTransferObjects.VehicleDTOs
{
    public record UpdateVehicleRequestDto
    {
        [RequiredGuid]
        public Guid Id { get; init; }
        [Required]
        public Guid ModelId { get; init; }
        [Required]
        public string LicensePlate { get; init; }
        [Required]
        public int Year { get; init; }
        [Required]
        public VehicleColor Color { get; init; }
        [Required]
        public decimal DailyPrice { get; init; }
        [Required]
        public VehicleStatus Status { get; init; }
    }
}
