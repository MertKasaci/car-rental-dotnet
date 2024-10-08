using CarRental.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Entities.DataTransferObjects.PaymentDTOs
{
    public record UpdatePaymentRequestDto
    {
        [RequiredGuid]
        public Guid Id { get; init; }
        [Required]
        public Guid ReservationId { get; init; }
        [Required]
        public decimal Amount { get; init; }
        [Required]
        public DateTime PaymentDate { get; init; }
        [Required]
        public PaymentMethod PaymentMethod { get; init; }
        [Required]
        public Guid CreditCardId { get; init; }
    }

}
