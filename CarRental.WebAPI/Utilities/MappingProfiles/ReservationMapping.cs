using AutoMapper;
using CarRental.Entities.DataTransferObjects.ReservationDTOs;
using CarRental.Entities.Models;

namespace CarRental.WebAPI.Utilities.MappingProfiles
{
    public class ReservationMapping : Profile
    {
        public ReservationMapping()
        {
            CreateMap<CreateReservationRequestDto, Reservation>();
            CreateMap<UpdateReservationRequestDto, Reservation>();
            CreateMap<Reservation, GetReservationResponseDto>();
            CreateMap<Reservation, GetReservationWithDetailsResponseDto>();
        }
    }
}
