using CarRental.Entities.Models;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Entities.DataTransferObjects.ReviewDTOs
{
    public record UpdateReviewRequestDto
    {
        [RequiredGuid]
        public Guid Id { get; init; }
        [Required]
        public Guid ReservationId { get; init; }
        public string? Content { get; init; }
        [Required]
        public int Rating { get; init; } // 1-5 arası bir değer
    } 
}
