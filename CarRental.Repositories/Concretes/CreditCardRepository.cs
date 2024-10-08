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
    public class CreditCardRepository : RepositoryBase<CreditCard>, ICreditCardRepository
    {
        public CreditCardRepository(CarRentalContext context) : base(context)
        {
        }

        public void CreateCreditCard(CreditCard creditCard) =>
            Create(creditCard);

        public void DeleteCreditCard(CreditCard creditCard) =>
            Delete(creditCard);


        public async Task<IEnumerable<CreditCard>> GetAllCreditCardsAsync(bool isTraceable) =>
            await FindAll(isTraceable)
            .OrderBy(cc => cc.Id)
            .ToListAsync();


        public async Task<CreditCard> GetCreditCardByIdAsync(Guid id, bool isTraceable) =>
             await FindByCondition((cc => cc.Id == id), isTraceable)
             .FirstOrDefaultAsync();

        public void UpdateCreditCard(CreditCard creditCard) =>
         Update(creditCard);
    }
}
