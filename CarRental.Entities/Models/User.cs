using CarRental.Entities.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.Models
{
    public class User : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? RefreshToken { get; set; }
        public Gender Gender { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<CreditCard> CreditCards { get; set; }
        public ICollection<Campaign> Campaigns { get; set; }

        public User()
        {
            Campaigns = new HashSet<Campaign>();
        }
    }
}
