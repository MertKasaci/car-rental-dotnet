using CarRental.Entities.DataTransferObjects.ReservationDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.DataTransferObjects.ReviewDTOs
{
    public record GetReviewWithDetailsResponseDto
    {
        public Guid Id { get; init; }
        public string Comment { get; init; }
        public int Rating { get; init; }
        public GetReservationWithDetailsResponseDto Reservation {  get; init; }
    }
}
