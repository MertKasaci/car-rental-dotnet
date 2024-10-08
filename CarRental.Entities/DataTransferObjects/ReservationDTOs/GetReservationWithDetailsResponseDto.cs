using CarRental.Entities.DataTransferObjects.LocationDTOs;
using CarRental.Entities.DataTransferObjects.ReviewDTOs;
using CarRental.Entities.DataTransferObjects.UserDTOs;
using CarRental.Entities.DataTransferObjects.VehicleDTOs;
using CarRental.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.DataTransferObjects.ReservationDTOs
{
    public record GetReservationWithDetailsResponseDto
    {
        public Guid Id { get; init; }
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }
        public decimal TotalCost { get; init; }
        public GetReviewResponseDto Review { get; init; }
        public GetUserDetailsResponseDto User { get; init; }
        public GetLocationResponseDto PickupLocation { get; init; }
        public GetLocationResponseDto DropoffLocation { get; init; }
        public GetVehicleResponseDto Vehicle { get; init; } 
    }
}
