using CarRental.Entities.Enums;

namespace CarRental.Entities.DataTransferObjects.PaymentDTOs
{
    public record GetPaymentResponseDto
    {
        public Guid Id { get; init; }
        public decimal Amount { get; init; }
        public DateTime PaymentDate { get; init; }
        public PaymentMethod PaymentMethod { get; init; }
    }

}
