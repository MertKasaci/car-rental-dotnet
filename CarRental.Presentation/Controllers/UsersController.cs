using CarRental.Entities.DataTransferObjects.UserDTOs;
using CarRental.Services.Concretes;
using CarRental.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Presentation.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public UsersController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var usersDetailsResponse = await _manager.UserService.GetAllUsers();

            return Ok(usersDetailsResponse);
        }

        [HttpGet("{userName}")]
        public async Task<IActionResult> GetUserByUserName([FromRoute] string userName)
        {
            var userDetailsResponse = await _manager.UserService.GetUserByUserName(userName);

            return Ok(userDetailsResponse);
      

        }

        [HttpPut("{userId}")]
        public async Task<IActionResult> UpdateUser(
        [FromRoute] Guid userId,
        [FromBody] UpdateUserRequestDto updateDto)
        {
            var result = await _manager.UserService.UpdateUserAsync(userId, updateDto);
            Console.WriteLine(result);
            if (result.Succeeded)
            {
                return Ok("Kullanıcı başarıyla güncellendi.");
            }

            return BadRequest(result.Errors);
        }
     

    }
}
