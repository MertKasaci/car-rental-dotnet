using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.Models
{
    public class Location : Entity
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public ICollection<Reservation> PickupReservations { get; set; }
        public ICollection<Reservation> DropoffReservations { get; set; }
    }
}
