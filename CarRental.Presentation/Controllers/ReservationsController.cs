using CarRental.Entities.DataTransferObjects.ReservationDTOs;
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
    [Route("api/reservations")]
    public class ReservationsController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public ReservationsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllReservationsAsync()
        {
            var reservations = await _manager.ReservationService.GetAllReservationsAsync(false);
            return Ok(reservations);

        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetReservationByIdAsync([FromRoute(Name = "id")] Guid id)
        {
            var reservation = await _manager.ReservationService.GetReservationByIdAsync(id, false);
            return Ok(reservation);

        }

        [HttpPost]
        public async Task<IActionResult> CreateReservationAsync([FromBody] CreateReservationRequestDto createReservationRequestDto)
        {
            var reservation = await _manager.ReservationService.CreateReservationAsync(createReservationRequestDto);
            return StatusCode(201, reservation);
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> UpdateReservationAsync([FromRoute(Name = "id")] Guid id,
            [FromBody] UpdateReservationRequestDto updateReservationRequestDto)
        {
            await _manager.ReservationService.UpdateReservationAsync(id, updateReservationRequestDto, false);
            return NoContent();
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeleteReservationAsync([FromRoute(Name = "id")] Guid id)
        {
            await _manager.ReservationService.DeleteReservationAsync(id, false);
            return NoContent();
        }
    }
}
