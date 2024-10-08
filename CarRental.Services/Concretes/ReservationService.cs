using AutoMapper;
using CarRental.Entities.DataTransferObjects.ReservationDTOs;
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
    public class ReservationService : IReservationService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public ReservationService(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<GetReservationResponseDto> CreateReservationAsync(CreateReservationRequestDto createReservationRequestDto)
        {
            if (createReservationRequestDto is null)
                throw new ArgumentNullException(nameof(createReservationRequestDto));

            var reservation = _mapper.Map<Reservation>(createReservationRequestDto);

            _manager.Reservation.CreateReservation(reservation);

            await _manager.SaveAsync();

            var reservationResponse = _mapper.Map<GetReservationResponseDto>(reservation);

            return reservationResponse;
        }

        public async Task DeleteReservationAsync(Guid id, bool isTraceable)
        {
            var entity = await _manager.Reservation.GetReservationByIdAsync(id, isTraceable);

            if (entity is null)
                throw new Exception($"Reservation with id:{id} could not found");

            _manager.Reservation.DeleteReservation(entity);
            await _manager.SaveAsync();
        }

        public async Task<IEnumerable<GetReservationWithDetailsResponseDto>> GetAllReservationsAsync(bool isTraceable)
        {
            var reservations = await _manager.Reservation.GetAllReservationsAsync(isTraceable);

            var reservationsResponse = _mapper.Map<IEnumerable<GetReservationWithDetailsResponseDto>>(reservations);

            return reservationsResponse;
        }

        public async Task<GetReservationResponseDto> GetReservationByIdAsync(Guid id, bool trackChanges)
        {
            var reservation = await _manager.Reservation.GetReservationByIdAsync(id, trackChanges);

            if (reservation is null)
                throw new Exception($"Reservation with id:{id} could not found");

            var reservationResponse = _mapper.Map<GetReservationResponseDto>(reservation);

            return reservationResponse;
        }

        public async Task UpdateReservationAsync(Guid id, UpdateReservationRequestDto updateReservationRequestDto, bool trackChanges)
        {
            var entity = await _manager.Reservation.GetReservationByIdAsync(id, trackChanges);
            if (entity is null)
                throw new Exception($"Reservation with id:{id} could not found.");


            entity = _mapper.Map<Reservation>(updateReservationRequestDto);
            ;

            _manager.Reservation.UpdateReservation(entity);
            await _manager.SaveAsync();


        }
    }
}
