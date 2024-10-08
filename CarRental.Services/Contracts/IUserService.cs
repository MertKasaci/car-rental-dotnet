using CarRental.Entities.DataTransferObjects.UserDTOs;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Contracts
{
    public interface IUserService
    {
        Task<IEnumerable<GetUserDetailsResponseDto>> GetAllUsers();
        Task<GetUserDetailsResponseDto> GetUserByUserName(string userName);
        Task<IdentityResult> UpdateUserAsync(Guid userId, UpdateUserRequestDto updateDto);
    }
}
