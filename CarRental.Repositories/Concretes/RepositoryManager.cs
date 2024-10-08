using CarRental.Repositories.Contracts;
using CarRental.Repositories.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.Concretes
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly CarRentalContext _context;
        private readonly IAddressRepository _addressRepository;
        private readonly IBrandRepository _brandRepository;
        private readonly ICreditCardRepository _creditCardRepository;
        private readonly ILocationRepository _locationRepository;
        private readonly IModelRepository _modelRepository;
        private readonly IPaymentRepository _paymentRepository;
        private readonly IReservationRepository _reservationRepository;
        private readonly IReviewRepository _reviewRepository;
        private readonly IVehicleRepository _vehicleRepository;
        private readonly ICampaignRepository _campaignRepository;

        public RepositoryManager(CarRentalContext context, 
            IAddressRepository addressRepository, 
            IBrandRepository brandRepository, 
            ICreditCardRepository creditCardRepository, 
            ILocationRepository locationRepository, 
            IModelRepository modelRepository, 
            IPaymentRepository paymentRepository, 
            IReservationRepository reservationRepository, 
            IReviewRepository reviewRepository, 
            IVehicleRepository vehicleRepository,
            ICampaignRepository campaignRepository
            )
        {
            _context = context;
            _addressRepository = addressRepository;
            _brandRepository = brandRepository;
            _creditCardRepository = creditCardRepository;
            _locationRepository = locationRepository;
            _modelRepository = modelRepository;
            _paymentRepository = paymentRepository;
            _reservationRepository = reservationRepository;
            _reviewRepository = reviewRepository;
            _vehicleRepository = vehicleRepository;
            _campaignRepository = campaignRepository;
        }

        public IAddressRepository Address => _addressRepository;

        public IBrandRepository Brand => _brandRepository;

        public ICreditCardRepository CreditCard => _creditCardRepository;
        public ILocationRepository Location => _locationRepository;

        public IModelRepository Model => _modelRepository;

        public IPaymentRepository Payment => _paymentRepository;

        public IReservationRepository Reservation => _reservationRepository;

        public IReviewRepository Review => _reviewRepository;

        public IVehicleRepository Vehicle => _vehicleRepository;

        public ICampaignRepository Campaign => _campaignRepository;

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
