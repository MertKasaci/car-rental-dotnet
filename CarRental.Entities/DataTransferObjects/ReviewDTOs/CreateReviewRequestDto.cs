using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.DataTransferObjects.ReviewDTOs
{
    public record CreateReviewRequestDto
    {
        [Required]
        public Guid ReservationId { get; init; }
        public string? Comment { get; init; }
        [Required]
        public int Rating { get; init; } // 1-5 arası bir değer
    }
}

