using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Contracts
{
    public interface IServiceManager
    {
        IBrandService BrandService { get; }
        IModelService ModelService { get; }
        IVehicleService VehicleService { get; }
        IAddressService AddressService { get; }
        ICreditCardService CreditCardService { get; }
        ILocationService LocationService { get; }
        IPaymentService PaymentService { get; }
        IReservationService ReservationService { get; }
        IReviewService ReviewService { get; }
        IAuthenticationService AuthenticationService { get; }
        IUserService UserService { get; }
        ICampaignService CampaignService { get; }
    }
}
