using CarRental.Entities.DataTransferObjects.LocationDTOs;
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
    [Route("api/locations")]
    public class LocationsController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public LocationsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLocationsAsync()
        {
            var locations = await _manager.LocationService.GetAllLocationsAsync(false);
            return Ok(locations);

        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetLocationByIdAsync([FromRoute(Name = "id")] Guid id)
        {
            var location = await _manager.LocationService.GetLocationByIdAsync(id, false);
            return Ok(location);

        }

        [HttpPost]
        public async Task<IActionResult> CreateLocationAsync([FromBody] CreateLocationRequestDto createLocationRequestDto)
        {
            var location = await _manager.LocationService.CreateLocationAsync(createLocationRequestDto);
            return StatusCode(201, location);
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> UpdateLocationAsync([FromRoute(Name = "id")] Guid id,
            [FromBody] UpdateLocationRequestDto updateLocationRequestDto)
        {
            await _manager.LocationService.UpdateLocationAsync(id, updateLocationRequestDto, false);
            return NoContent();
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeleteLocationAsync([FromRoute(Name = "id")] Guid id)
        {
            await _manager.LocationService.DeleteLocationAsync(id, false);
            return NoContent();
        }



    }
}

