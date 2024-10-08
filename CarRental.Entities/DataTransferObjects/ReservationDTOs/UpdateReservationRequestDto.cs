using CarRental.Entities.Models;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Entities.DataTransferObjects.ReservationDTOs
{
    public record UpdateReservationRequestDto
    {
        [RequiredGuid]
        public Guid Id { get; init; }
        [Required]
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
