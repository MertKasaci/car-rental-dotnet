using AutoMapper;
using CarRental.Entities.DataTransferObjects.PaymentDTOs;
using CarRental.Entities.Models;

namespace CarRental.WebAPI.Utilities.MappingProfiles
{
    public class PaymentMapping : Profile
    {

        public PaymentMapping()
        {
            CreateMap<CreatePaymentRequestDto, Payment>();
            CreateMap<UpdatePaymentRequestDto, Payment>();
            CreateMap<Payment, GetPaymentResponseDto>();
        }

    }
}
