using CarRental.Entities.DataTransferObjects.UserDTOs;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Contracts
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> Registration(UserRegisterDto userRegisterDto);
        Task<bool> ValidateUser(UserLoginDto userLoginDto);
        Task<TokenDto> CreateToken(bool populateExp);
        Task<TokenDto> RefreshToken(TokenDto tokenDto);
    }
}
