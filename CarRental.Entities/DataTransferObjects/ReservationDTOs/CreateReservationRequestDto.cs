using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.DataTransferObjects.ReservationDTOs
{
    public record CreateReservationRequestDto
    {
        [RequiredGuid]
        public Guid VehicleId { get; init; }
        [RequiredGuid]
        public Guid UserId { get; init; }
        [Required]
        public DateTime StartDate { get; init; }
        [Required]
        public DateTime EndDate { get; init; }
        [Required]
        public decimal TotalCost { get; init; }
        [Required]
        public Guid PickupLocationId { get; init; }
        [Required]
        public Guid DropoffLocationId { get; init; }
    } 
}
