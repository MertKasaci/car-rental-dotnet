using CarRental.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.DataTransferObjects.AddressDTOs
{
    public record CreateAddressRequestDto
    {
        [Required(ErrorMessage = "Please choose any location.")]
        public Guid LocationId { get; set; }
        [Required(ErrorMessage = "Street is required field.")]
        public string Street { get; set; }
        [Required(ErrorMessage = "City is required field.")]
        public City City { get; set; }
        [Required(ErrorMessage = "State is required field.")]
        public string State { get; set; }
        public string? ZipCode { get; set; }
        
    }
}
