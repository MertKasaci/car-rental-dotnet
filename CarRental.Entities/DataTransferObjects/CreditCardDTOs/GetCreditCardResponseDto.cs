using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.DataTransferObjects.CreditCardDTOs
{
    public record GetCreditCardResponseDto
    {
        public Guid Id { get; init; }
        public string CardNumber { get; init; }
        public string CardHolderName { get; init; }
        public string ExpiryMonth { get; init; }
        public string ExpiryYear { get; init; }
        public string CVV { get; init; }
    }
}
