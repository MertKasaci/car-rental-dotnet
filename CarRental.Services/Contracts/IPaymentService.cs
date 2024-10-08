using CarRental.Entities.DataTransferObjects.PaymentDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Contracts
{
    public interface IPaymentService
    {
        Task<IEnumerable<GetPaymentResponseDto>> GetAllPaymentsAsync(bool isTraceable);
        Task<GetPaymentResponseDto> GetPaymentByIdAsync(Guid id, bool isTraceable);
        Task<GetPaymentResponseDto> CreatePaymentAsync(CreatePaymentRequestDto createPaymentRequestDto);
        Task UpdatePaymentAsync(Guid id, UpdatePaymentRequestDto updatePaymentRequestDto, bool isTraceable);
        Task DeletePaymentAsync(Guid id, bool isTraceable);
    }
}
