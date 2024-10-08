using System.ComponentModel.DataAnnotations;

namespace CarRental.Entities.DataTransferObjects.LocationDTOs
{
    public record UpdateLocationRequestDto
    {
        [RequiredGuid]
        public Guid Id { get; init; }
        [Required]
        public string Name { get; init; }
    }

}
