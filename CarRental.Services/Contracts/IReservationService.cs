using CarRental.Entities.DataTransferObjects.ReservationDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Contracts
{
    public interface IReservationService
    {
        Task<IEnumerable<GetReservationWithDetailsResponseDto>> GetAllReservationsAsync(bool isTraceable);
        Task<GetReservationResponseDto> GetReservationByIdAsync(Guid id, bool isTraceable);
        Task<GetReservationResponseDto> CreateReservationAsync(CreateReservationRequestDto createReservationRequestDto);
        Task UpdateReservationAsync(Guid id, UpdateReservationRequestDto updateReservationRequestDto, bool isTraceable);
        Task DeleteReservationAsync(Guid id, bool isTraceable);
    }
}
