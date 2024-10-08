using CarRental.Entities.DataTransferObjects.AddressDTOs;
using CarRental.Entities.Models;

namespace CarRental.Entities.DataTransferObjects.LocationDTOs
{
    public record GetLocationResponseDto
    {
        public Guid Id { get; init; }
        public GetAddressResponseDto Address { get; set; }
        public string Name { get; init; }
    }



}
