using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.DataTransferObjects.BrandDTOs
{
    public record GetBrandResponseDto
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
    }
}
