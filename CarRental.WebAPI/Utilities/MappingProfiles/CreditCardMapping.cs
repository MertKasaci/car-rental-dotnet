using AutoMapper;
using CarRental.Entities.DataTransferObjects.CreditCardDTOs;
using CarRental.Entities.Models;

namespace CarRental.WebAPI.Utilities.MappingProfiles
{
    public class CreditCardMapping : Profile
    {
        public CreditCardMapping()
        {
            CreateMap<CreateCreditCardRequestDto, CreditCard>();
            CreateMap<UpdateCreditCardRequestDto, CreditCard>();
            CreateMap<CreditCard, GetCreditCardResponseDto>();
        }

    }
}
