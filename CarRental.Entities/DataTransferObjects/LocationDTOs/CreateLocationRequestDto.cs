using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.DataTransferObjects.LocationDTOs
{
    public record CreateLocationRequestDto
    {
        [Required]
        public string Name { get; init; }
    }



}
