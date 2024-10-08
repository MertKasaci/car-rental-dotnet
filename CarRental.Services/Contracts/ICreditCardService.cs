using CarRental.Entities.DataTransferObjects.CreditCardDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Contracts
{
    public interface ICreditCardService
    {
        Task<IEnumerable<GetCreditCardResponseDto>> GetAllCreditCardsAsync(bool isTraceable);
        Task<GetCreditCardResponseDto> GetCreditCardByIdAsync(Guid id, bool isTraceable);
        Task<GetCreditCardResponseDto> CreateCreditCardAsync(CreateCreditCardRequestDto createCreditCardRequestDto);
        Task UpdateCreditCardAsync(Guid id, UpdateCreditCardRequestDto updateCreditCardRequestDto, bool isTraceable);
        Task DeleteCreditCardAsync(Guid id, bool isTraceable);

    }
}
