using CarRental.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Concretes
{
    public class ServiceManager : IServiceManager
    {

        private readonly IBrandService _brandService;
        private readonly IModelService _modelService;
        private readonly IVehicleService _vehicleService;
        private readonly IAddressService _addressService;
        private readonly ICreditCardService _creditCardService;
        private readonly ILocationService _locationService;
        private readonly IPaymentService _paymentService;
        private readonly IReservationService _reservationService;
        private readonly IReviewService _reviewService;
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserService _userService;
        private readonly ICampaignService _campaignService;

        public ServiceManager(IBrandService brandService, 
            IModelService modelService, 
            IVehicleService vehicleService, 
            IAddressService addressService, 
            ICreditCardService creditCardService, 
            ILocationService locationService, 
            IPaymentService paymentService, 
            IReservationService reservationService, 
            IReviewService reviewService, 
            IAuthenticationService authenticationService, 
            IUserService userService,
            ICampaignService campaignService
            )
        {
            _brandService = brandService;
            _modelService = modelService;
            _vehicleService = vehicleService;
            _addressService = addressService;
            _creditCardService = creditCardService;
            _locationService = locationService;
            _paymentService = paymentService;
            _reservationService = reservationService;
            _reviewService = reviewService;
            _authenticationService = authenticationService;
            _userService = userService;
            _campaignService = campaignService;
        }

        public IBrandService BrandService => _brandService;

        public IModelService ModelService => _modelService;

        public IVehicleService VehicleService => _vehicleService;

        public IAddressService AddressService => _addressService;

        public ICreditCardService CreditCardService => _creditCardService;

        public ILocationService LocationService => _locationService;

        public IPaymentService PaymentService => _paymentService;

        public IReservationService ReservationService => _reservationService;

        public IReviewService ReviewService => _reviewService;

        public IAuthenticationService AuthenticationService => _authenticationService;

        public IUserService UserService => _userService;

        public ICampaignService CampaignService => _campaignService;
    }
}
