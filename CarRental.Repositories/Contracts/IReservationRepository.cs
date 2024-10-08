using CarRental.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.Contracts
{
    public interface IReservationRepository : IRepositoryBase<Reservation> 
    {
        Task<IEnumerable<Reservation>> GetAllReservationsAsync(bool isTraceable);
        Task<Reservation> GetReservationByIdAsync(Guid id, bool isTraceable);
        void CreateReservation(Reservation reservation);
        void UpdateReservation(Reservation reservation);
        void DeleteReservation(Reservation reservation);

    }
}
