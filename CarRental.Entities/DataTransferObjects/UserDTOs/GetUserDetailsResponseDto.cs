using CarRental.Entities.DataTransferObjects.ReservationDTOs;
using CarRental.Entities.Enums;
using CarRental.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.DataTransferObjects.UserDTOs
{
    public record GetUserDetailsResponseDto
    {
        public Guid Id { get; set; }
        public string UserName { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Email { get; init; }
        public string PhoneNumber { get; init; }
        public Gender Gender { get; init; }

    }
}
