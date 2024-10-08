using CarRental.Entities.DataTransferObjects.PaymentDTOs;
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
    [Route("api/payments")]
    public class PaymentsController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public PaymentsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPaymentsAsync()
        {
            var payments = await _manager.PaymentService.GetAllPaymentsAsync(false);
            return Ok(payments);

        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetPaymentByIdAsync([FromRoute(Name = "id")] Guid id)
        {
            var payment = await _manager.PaymentService.GetPaymentByIdAsync(id, false);
            return Ok(payment);

        }

        [HttpPost]
        public async Task<IActionResult> CreatePaymentAsync([FromBody] CreatePaymentRequestDto createPaymentRequestDto)
        {
            var payment = await _manager.PaymentService.CreatePaymentAsync(createPaymentRequestDto);
            return StatusCode(201, payment);
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> UpdatePaymentAsync([FromRoute(Name = "id")] Guid id,
            [FromBody] UpdatePaymentRequestDto updatePaymentRequestDto)
        {
            await _manager.PaymentService.UpdatePaymentAsync(id, updatePaymentRequestDto, false);
            return NoContent();
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeletePaymentAsync([FromRoute(Name = "id")] Guid id)
        {
            await _manager.PaymentService.DeletePaymentAsync(id, false);
            return NoContent();
        }


    }
}
