using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.Models
{
    public class CreditCard : Entity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string CVV { get; set; }
    }
}
