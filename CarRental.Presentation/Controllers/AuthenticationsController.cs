using CarRental.Entities.DataTransferObjects.UserDTOs;
using CarRental.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Presentation.Controllers
{
    [ApiController]
    [Route("api/authentication")]
    public class AuthenticationsController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public AuthenticationsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Registration([FromBody] UserRegisterDto userRegisterDto)
        {
            var result = await _manager.AuthenticationService.Registration(userRegisterDto);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            return StatusCode(201);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Authentication([FromBody] UserLoginDto userLoginDto)
        {
            var result = await _manager.AuthenticationService.ValidateUser(userLoginDto);
            if (!result)
            {
                return Unauthorized(); //401
            }

            var tokenDto = await _manager.AuthenticationService.CreateToken(true);

            return Ok(tokenDto);
        }

        [HttpPost("refresh")]
        public async Task<IActionResult> Refresh([FromBody] TokenDto tokenDto)
        {
            var tokenDtoToReturn = await _manager.AuthenticationService
                .RefreshToken(tokenDto);

            return Ok(tokenDtoToReturn);
        }
    }
}
