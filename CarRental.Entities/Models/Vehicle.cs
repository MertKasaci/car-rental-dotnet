using CarRental.Entities.Enums;

namespace CarRental.Entities.Models
{
    public class Vehicle : Entity
    {
        public Guid ModelId { get; set; }
        public Model Model { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }
        public VehicleColor Color { get; set; }
        public decimal DailyPrice { get; set; }
        public VehicleStatus Status{ get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        

    }
}