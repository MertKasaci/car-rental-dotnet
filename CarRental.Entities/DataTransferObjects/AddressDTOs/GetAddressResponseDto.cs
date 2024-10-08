using CarRental.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.DataTransferObjects.AddressDTOs
{
    public record GetAddressResponseDto
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public City City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        

    }
}
