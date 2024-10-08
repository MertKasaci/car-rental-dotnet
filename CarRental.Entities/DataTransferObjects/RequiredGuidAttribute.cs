using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.DataTransferObjects
{
    public class RequiredGuidAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is Guid guid && guid == Guid.Empty)
            {
                return new ValidationResult("The Id Field Is Required.");
            }

            return ValidationResult.Success;
        }
    }
}
