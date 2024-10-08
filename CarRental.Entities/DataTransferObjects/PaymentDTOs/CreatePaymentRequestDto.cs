using CarRental.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.DataTransferObjects.PaymentDTOs
{
    public record CreatePaymentRequestDto
    {
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
