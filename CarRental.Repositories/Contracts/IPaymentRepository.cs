using CarRental.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.Contracts
{
    public interface IPaymentRepository : IRepositoryBase<Payment>
    {
        Task<IEnumerable<Payment>> GetAllPaymentsAsync(bool isTraceable);
        Task<Payment> GetPaymentByIdAsync(Guid id, bool isTraceable);
        void CreatePayment(Payment payment);
        void UpdatePayment(Payment payment);
        void DeletePayment(Payment payment);
    }
}
