 using System.Data.Common;

namespace CarRental.Entities.Models
{
    public class Reservation : Entity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalCost { get; set; }
        public Review Review { get; set; }
        public Payment Payment { get; set; }
        public Guid PickupLocationId { get; set; }
        public Location PickupLocation { get; set; }
        public Guid DropoffLocationId { get; set; }
        public Location DropoffLocation { get; set; }
    }
}