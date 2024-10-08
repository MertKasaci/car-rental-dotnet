using AutoMapper;
using CarRental.Entities.DataTransferObjects.ReviewDTOs;
using CarRental.Entities.DataTransferObjects.UserDTOs;
using CarRental.Entities.Models;
using CarRental.Services.Contracts;
using CarRental.Services.Contracts.Logger;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Concretes
{
    public class UserService : IUserService
    {
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _manager;
        

        public UserService(ILoggerService logger, IMapper mapper, UserManager<User> manager)
        {
            _logger = logger;
            _mapper = mapper;
            _manager = manager;
        }

        public async Task<IEnumerable<GetUserDetailsResponseDto>> GetAllUsers()
        {
            var users = await _manager
                .Users
                .Include(u => u.Reservations)
                .ToListAsync();

            var usersDetailsResponse = _mapper.Map<IEnumerable<GetUserDetailsResponseDto>>(users);

            return usersDetailsResponse;
        }
    

        public async Task<GetUserDetailsResponseDto> GetUserByUserName(string userName)
        {
            var user = await _manager.FindByNameAsync(userName);

            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            var userDetailsResponse = _mapper.Map<GetUserDetailsResponseDto>(user);

            return userDetailsResponse; 
            
        }

        public async Task<IdentityResult> UpdateUserAsync(Guid userId, UpdateUserRequestDto updateDto)
        {
            var user = await _manager.FindByIdAsync(userId.ToString());

            if (user == null)
            {
                return IdentityResult.Failed(new IdentityError { Description = "Kullanıcı bulunamadı." });
            }

            _mapper.Map(updateDto, user);

            user.NormalizedEmail = _manager.NormalizeEmail(updateDto.Email);
            user.NormalizedUserName = _manager.NormalizeName(updateDto.UserName);
            

            var result = await _manager.UpdateAsync(user);
            Console.WriteLine(result);
            return result;
        }
    }
}
