using CarRental.Entities.Enums;

namespace CarRental.Entities.Models
{
    public class Model : Entity
    {
        public string Name { get; set; }
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; }
       
        public int Capacity { get; set; }
        public FuelType FuelType { get; set; }
        public int LuggageCapacity { get; set; }
        public TransmissionType TransmissionType { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }

    }
}