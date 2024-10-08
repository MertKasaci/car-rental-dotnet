using CarRental.Entities.DataTransferObjects.VehicleDTOs;
using CarRental.Entities.RequestFeatures;
using CarRental.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarRental.Presentation.Controllers
{
    [ApiController]
    [Route("api/vehicles")]
    public class VehiclesController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public VehiclesController(IServiceManager manager)
        {
            _manager = manager;
        }

        
        [HttpGet]
        public async Task<IActionResult> GetAllVehiclesAsync([FromQuery] VehicleParameters vehiclesParameters)
        {
            var pagedVehiclesResponse = await _manager
               .VehicleService
               .GetAllVehiclesAsync(vehiclesParameters,false);
               

            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(pagedVehiclesResponse.metaData));

            return Ok(pagedVehiclesResponse.vehicles);

        }

        [HttpGet("details")]
        public async Task<IActionResult> GetAllVehiclesByDetailsAsync()
        {
            var vehicles = await _manager.VehicleService.GetAllVehiclesByDetailsAsync(false);
            return Ok(vehicles);

        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetVehicleByIdAsync([FromRoute(Name = "id")] Guid id)
        {
            var vehicle = await _manager.VehicleService.GetVehicleByIdAsync(id, false);
            return Ok(vehicle);

        }

        [HttpPost]
        public async Task<IActionResult> CreateVehicleAsync([FromBody] CreateVehicleRequestDto createVehicleRequestDto)
        {
            var vehicle = await _manager.VehicleService.CreateVehicleAsync(createVehicleRequestDto);
            return StatusCode(201, vehicle);
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> UpdateVehicleAsync([FromRoute(Name = "id")] Guid id,
            [FromBody] UpdateVehicleRequestDto updateVehicleRequestDto)
        {
            await _manager.VehicleService.UpdateVehicleAsync(id, updateVehicleRequestDto, false);
            return NoContent();
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeleteVehicleAsync([FromRoute(Name = "id")] Guid id)
        {
            await _manager.VehicleService.DeleteVehicleAsync(id, false);
            return NoContent();
        }
    }
}
