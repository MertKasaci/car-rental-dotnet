using CarRental.Entities.DataTransferObjects.CreditCardDTOs;
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
    [Route("api/creditcards")]
    public class CreditCardsController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public CreditCardsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCreditCardsAsync()
        {
            var creditCards = await _manager.CreditCardService.GetAllCreditCardsAsync(false);
            return Ok(creditCards);

        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetCreditCardByIdAsync([FromRoute(Name = "id")] Guid id)
        {
            var creditCard = await _manager.CreditCardService.GetCreditCardByIdAsync(id, false);
            return Ok(creditCard);

        }

        [HttpPost]
        public async Task<IActionResult> CreateCreditCardAsync([FromBody] CreateCreditCardRequestDto createCreditCardRequestDto)
        {
            var creditCard = await _manager.CreditCardService.CreateCreditCardAsync(createCreditCardRequestDto);
            return StatusCode(201, creditCard);
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> UpdateCreditCardAsync([FromRoute(Name = "id")] Guid id,
            [FromBody] UpdateCreditCardRequestDto updateCreditCardRequestDto)
        {
            await _manager.CreditCardService.UpdateCreditCardAsync(id, updateCreditCardRequestDto, false);
            return NoContent();
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeleteCreditCardAsync([FromRoute(Name = "id")] Guid id)
        {
            await _manager.CreditCardService.DeleteCreditCardAsync(id, false);
            return NoContent();
        }
    }
}
