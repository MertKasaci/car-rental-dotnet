using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.Models
{
    public class Review : Entity
    {
        public Guid ReservationId { get; set; }
        public Reservation Reservation { get; set; }
        public string? Comment { get; set; }
        public int Rating { get; set; } // 1-5 arası bir değer
    }
}
