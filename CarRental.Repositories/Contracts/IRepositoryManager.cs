using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IAddressRepository Address { get; }
        IBrandRepository Brand { get; }
        ICreditCardRepository CreditCard { get; }
        ILocationRepository Location { get; }
        IModelRepository Model { get; }
        IPaymentRepository Payment { get; }
        IReservationRepository Reservation { get; }
        IReviewRepository Review { get; }
        IVehicleRepository Vehicle { get; }
        ICampaignRepository Campaign { get; }
        Task SaveAsync();
    }
}
