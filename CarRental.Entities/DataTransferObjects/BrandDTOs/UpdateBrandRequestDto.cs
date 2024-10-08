using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.DataTransferObjects.BrandDTOs
{
    public record UpdateBrandRequestDto
    {
        [RequiredGuid]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; init; }
    }
}
