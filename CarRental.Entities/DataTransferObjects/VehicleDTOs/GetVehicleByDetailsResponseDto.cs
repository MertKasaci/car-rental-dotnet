using CarRental.Entities.DataTransferObjects.ModelDTOs;
using CarRental.Entities.DataTransferObjects.ReservationDTOs;
using CarRental.Entities.Enums;
using CarRental.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.DataTransferObjects.VehicleDTOs
{
    public record GetVehicleByDetailsResponseDto
    {
        public Guid Id { get; init; }
        public int Year { get; init; }
        public string LicensePlate { get; init; }
        public VehicleColor Color { get; init; }
        public decimal DailyPrice { get; init; }
        public VehicleStatus Status { get; init; }
        public ICollection<GetReservationWithDetailsResponseDto> Reservations { get; init; }
        public GetModelResponseDto Model{ get; init; }
    }
}
