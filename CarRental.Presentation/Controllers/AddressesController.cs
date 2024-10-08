using CarRental.Entities.DataTransferObjects.AddressDTOs;
using CarRental.Presentation.ActionFilters;
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
    [ServiceFilter(typeof(LogFilterAttribute),Order = 1)]
    [Route("api/addresses")]
    public class AddressesController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public AddressesController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAddressesAsync()
        {
            var brands = await _manager.AddressService.GetAllAddressesAsync(false);
            return Ok(brands);

        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetAddressByIdAsync([FromRoute(Name = "id")] Guid id)
        {
            var brand = await _manager.AddressService.GetAddressByIdAsync(id, false);
            return Ok(brand);

        }

        [HttpPost]
        public async Task<IActionResult> CreateAddressAsync([FromBody] CreateAddressRequestDto createAddressRequestDto)
        {
            var brand = await _manager.AddressService.CreateAddressAsync(createAddressRequestDto);
            return StatusCode(201, brand);
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> UpdateAddressAsync([FromRoute(Name = "id")] Guid id,
            [FromBody] UpdateAddressRequestDto updateAddressRequestDto)
        {
            await _manager.AddressService.UpdateAddressAsync(id, updateAddressRequestDto, false);
            return NoContent();
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeleteAddressAsync([FromRoute(Name = "id")] Guid id)
        {
            await _manager.AddressService.DeleteAddressAsync(id, false);
            return NoContent();
        }

    }
}
