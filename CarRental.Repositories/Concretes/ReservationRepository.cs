using CarRental.Entities.Models;
using CarRental.Repositories.Contracts;
using CarRental.Repositories.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.Concretes
{
    public class ReservationRepository : RepositoryBase<Reservation>, IReservationRepository
    {
        public ReservationRepository(CarRentalContext context) : base(context)
        {
        }

        public void CreateReservation(Reservation reservation) =>
            Create(reservation);
        

        public void DeleteReservation(Reservation reservation) =>
            Delete(reservation);


        public async Task<IEnumerable<Reservation>> GetAllReservationsAsync(bool isTraceable) =>
            await FindAll(isTraceable)
            .Include(r=> r.User)
            .Include(r=> r.DropoffLocation)
            .ThenInclude(l => l.Address)
            .Include(r => r.PickupLocation)
            .ThenInclude(l => l.Address)
            .Include(r => r.Vehicle)
            .ThenInclude(v => v.Model)
            .Include(r => r.Review)
            .OrderBy(r => r.Id)
            .ToListAsync();


        public async Task<Reservation> GetReservationByIdAsync(Guid id, bool isTraceable) =>
            await FindByCondition((r => r.Id == id), isTraceable)
            .Include(r => r.User)
            .Include(r => r.DropoffLocation)
            .ThenInclude(l => l.Address)
            .Include(r => r.PickupLocation)
            .ThenInclude(l => l.Address)
            .Include(r => r.Review)
            .FirstOrDefaultAsync();
        

        public void UpdateReservation(Reservation reservation) =>
            Update(reservation);
        
    }
}
