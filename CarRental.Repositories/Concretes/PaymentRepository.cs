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
    public class PaymentRepository : RepositoryBase<Payment>, IPaymentRepository
    {
        public PaymentRepository(CarRentalContext context) : base(context)
        {
        }

        public void CreatePayment(Payment payment) =>
            Create(payment);
        

        public void DeletePayment(Payment payment) =>
            Delete(payment);


        public async Task<IEnumerable<Payment>> GetAllPaymentsAsync(bool isTraceable) =>
            await FindAll(isTraceable)
            .OrderBy(p => p.Id)
            .ToListAsync();


        public async Task<Payment> GetPaymentByIdAsync(Guid id, bool isTraceable) =>
            await FindByCondition((p => p.Id == id), isTraceable)
            .FirstOrDefaultAsync();
        

        public void UpdatePayment(Payment payment) =>
            Update(payment);
         
    }
}
