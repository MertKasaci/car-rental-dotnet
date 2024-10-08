using CarRental.Entities.DataTransferObjects.ReviewDTOs;
using CarRental.Entities.RequestFeatures;
using CarRental.Services.Contracts;
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
    [Route("api/reviews")]
    public class ReviewsController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public ReviewsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllReviewsAsync([FromQuery] ReviewParameters reviewParameters)
        {
            var pagedReviewsResponse = await _manager
               .ReviewService
               .GetAllReviewsAsync(reviewParameters, false);


            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(pagedReviewsResponse.metaData));

            return Ok(pagedReviewsResponse.reviews);


        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetReviewByIdAsync([FromRoute(Name = "id")] Guid id)
        {
            var review = await _manager.ReviewService.GetReviewByIdAsync(id, false);
            return Ok(review);

        }

        [HttpPost]
        public async Task<IActionResult> CreateReviewAsync([FromBody] CreateReviewRequestDto createReviewRequestDto)
        {
            var review = await _manager.ReviewService.CreateReviewAsync(createReviewRequestDto);
            return StatusCode(201, review);
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> UpdateReviewAsync([FromRoute(Name = "id")] Guid id,
            [FromBody] UpdateReviewRequestDto updateReviewRequestDto)
        {
            await _manager.ReviewService.UpdateReviewAsync(id, updateReviewRequestDto, false);
            return NoContent();
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeleteReviewAsync([FromRoute(Name = "id")] Guid id)
        {
            await _manager.ReviewService.DeleteReviewAsync(id, false);
            return NoContent();
        }
    }
}
