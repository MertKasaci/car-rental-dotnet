using AutoMapper;
using CarRental.Entities.DataTransferObjects.CreditCardDTOs;
using CarRental.Entities.Models;
using CarRental.Repositories.Contracts;
using CarRental.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Concretes
{
    public class CreditCardService : ICreditCardService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public CreditCardService(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<GetCreditCardResponseDto> CreateCreditCardAsync(CreateCreditCardRequestDto createCreditCardRequestDto)
        {
            if (createCreditCardRequestDto is null)
                throw new ArgumentNullException(nameof(createCreditCardRequestDto));

            var creditCard = _mapper.Map<CreditCard>(createCreditCardRequestDto);

            _manager.CreditCard.CreateCreditCard(creditCard);

            await _manager.SaveAsync();

            var creditCardResponse = _mapper.Map<GetCreditCardResponseDto>(creditCard);

            return creditCardResponse;
        }

        public async Task DeleteCreditCardAsync(Guid id, bool isTraceable)
        {
            var entity = await _manager.CreditCard.GetCreditCardByIdAsync(id, isTraceable);

            if (entity is null)
                throw new Exception($"CreditCard with id:{id} could not found");

            _manager.CreditCard.DeleteCreditCard(entity);
            await _manager.SaveAsync();
        }

        public async Task<IEnumerable<GetCreditCardResponseDto>> GetAllCreditCardsAsync(bool isTraceable)
        {
            var creditCards = await _manager.CreditCard.GetAllCreditCardsAsync(isTraceable);

            var creditCardsResponse = _mapper.Map<IEnumerable<GetCreditCardResponseDto>>(creditCards);

            return creditCardsResponse;
        }

        public async Task<GetCreditCardResponseDto> GetCreditCardByIdAsync(Guid id, bool trackChanges)
        {
            var creditCard = await _manager.CreditCard.GetCreditCardByIdAsync(id, trackChanges);

            if (creditCard is null)
                throw new Exception($"CreditCard with id:{id} could not found");

            var creditCardResponse = _mapper.Map<GetCreditCardResponseDto>(creditCard);

            return creditCardResponse;
        }

        public async Task UpdateCreditCardAsync(Guid id, UpdateCreditCardRequestDto updateCreditCardRequestDto, bool trackChanges)
        {
            var entity = await _manager.CreditCard.GetCreditCardByIdAsync(id, trackChanges);
            if (entity is null)
                throw new Exception($"CreditCard with id:{id} could not found.");


            entity = _mapper.Map<CreditCard>(updateCreditCardRequestDto);
            ;

            _manager.CreditCard.UpdateCreditCard(entity);
            await _manager.SaveAsync();


        }

    }
}
