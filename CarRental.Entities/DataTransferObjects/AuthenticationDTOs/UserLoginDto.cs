﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.DataTransferObjects.UserDTOs
{
    public record UserLoginDto
    {
       [Required(ErrorMessage = "Email is required. " )]
        public string? Email { get; init; }
       [Required(ErrorMessage = "Password is required. ")]
        public string? Password { get; init; }
    }
}
