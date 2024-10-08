using CarRental.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.Contracts
{
    public interface ICreditCardRepository : IRepositoryBase<CreditCard>
    {
        Task<IEnumerable<CreditCard>> GetAllCreditCardsAsync(bool isTraceable);
        Task<CreditCard> GetCreditCardByIdAsync(Guid id, bool isTraceable);
        void CreateCreditCard(CreditCard creditCard);
        void UpdateCreditCard(CreditCard creditCard);
        void DeleteCreditCard(CreditCard creditCard);

    }
}
