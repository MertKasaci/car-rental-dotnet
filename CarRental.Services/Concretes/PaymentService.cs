using AutoMapper;
using CarRental.Entities.DataTransferObjects.PaymentDTOs;
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
    public class PaymentService : IPaymentService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public PaymentService(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<GetPaymentResponseDto> CreatePaymentAsync(CreatePaymentRequestDto createPaymentRequestDto)
        {
            if (createPaymentRequestDto is null)
                throw new ArgumentNullException(nameof(createPaymentRequestDto));

            var payment = _mapper.Map<Payment>(createPaymentRequestDto);

            _manager.Payment.CreatePayment(payment);

            await _manager.SaveAsync();

            var paymentResponse = _mapper.Map<GetPaymentResponseDto>(payment);

            return paymentResponse;
        }

        public async Task DeletePaymentAsync(Guid id, bool isTraceable)
        {
            var entity = await _manager.Payment.GetPaymentByIdAsync(id, isTraceable);

            if (entity is null)
                throw new Exception($"Payment with id:{id} could not found");

            _manager.Payment.DeletePayment(entity);
            await _manager.SaveAsync();
        }

        public async Task<IEnumerable<GetPaymentResponseDto>> GetAllPaymentsAsync(bool isTraceable)
        {
            var payments = await _manager.Payment.GetAllPaymentsAsync(isTraceable);

            var paymentsResponse = _mapper.Map<IEnumerable<GetPaymentResponseDto>>(payments);

            return paymentsResponse;
        }

        public async Task<GetPaymentResponseDto> GetPaymentByIdAsync(Guid id, bool trackChanges)
        {
            var payment = await _manager.Payment.GetPaymentByIdAsync(id, trackChanges);

            if (payment is null)
                throw new Exception($"Payment with id:{id} could not found");

            var paymentResponse = _mapper.Map<GetPaymentResponseDto>(payment);

            return paymentResponse;
        }

        public async Task UpdatePaymentAsync(Guid id, UpdatePaymentRequestDto updatePaymentRequestDto, bool trackChanges)
        {
            var entity = await _manager.Payment.GetPaymentByIdAsync(id, trackChanges);
            if (entity is null)
                throw new Exception($"Payment with id:{id} could not found.");


            entity = _mapper.Map<Payment>(updatePaymentRequestDto);
            ;

            _manager.Payment.UpdatePayment(entity);
            await _manager.SaveAsync();


        }
    }
}
