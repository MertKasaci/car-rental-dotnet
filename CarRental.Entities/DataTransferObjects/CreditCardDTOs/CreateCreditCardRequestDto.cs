using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.DataTransferObjects.CreditCardDTOs
{
    public record CreateCreditCardRequestDto
    {
        [RequiredGuid]
        public Guid Id { get; init; }
        [RequiredGuid]
        public Guid UserId { get; init; }
        [Required]
        public string CardNumber { get; init; }
        [Required]
        public string CardHolderName { get; init; }
        [Required]
        public string ExpiryMonth { get; init; }
        [Required]
        public string ExpiryYear { get; init; }
        [Required]
        public string CVV { get; init; }

    }
}
