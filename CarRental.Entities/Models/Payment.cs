using CarRental.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.Models
{
    public class Payment : Entity
    {
        public Guid ReservationId { get; set; }
        public Reservation Reservation { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public Guid? CreditCardId { get; set; }
        public CreditCard? CreditCard { get; set; }
      
    }
}
