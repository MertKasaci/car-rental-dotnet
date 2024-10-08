using CarRental.Entities.DataTransferObjects.CampaignDTOs;
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
    [Route("api/campaigns")]
    public class CampaignsController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public CampaignsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCampaignsAsync([FromQuery] CampaignParameters campaignParameters)
        {
            var pagedCampaignsResponse = await _manager
            .CampaignService
               .GetAllCampaignsAsync(campaignParameters, false);


            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(pagedCampaignsResponse.metaData));

            return Ok(pagedCampaignsResponse.campaigns);
        }

        [HttpGet("users/{userId:Guid}/available-campaigns")]
        public async Task<IActionResult> GetAvailableCampaignsForUser([FromRoute(Name ="userId")] Guid userId)
        {
            var availableCampaignsForUserResponse = await _manager.CampaignService.GetAvailableCampaignsForUserAsync(userId, false);

            return Ok(availableCampaignsForUserResponse);
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetCampaignByIdAsync([FromRoute(Name ="id")]Guid id)
        {
            var campaign = await _manager.CampaignService.GetCampaignByIdAsync(id, false);
            return Ok(campaign);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCampaignAsync([FromBody] CreateCampaignRequestDto createCampaignRequestDto)
        {
            var review = await _manager.CampaignService.CreateCampaignAsync(createCampaignRequestDto);
            return StatusCode(201, review);
        }
        [HttpPost("{campaignId:Guid}/users/{userId:Guid}")]
        public async Task<IActionResult> AddCampaignToUserAsync([FromRoute(Name ="campaignId")]Guid campaignId, [FromRoute(Name = "userId")] Guid userId)
        {
            var campaignResponse = await _manager.CampaignService.AddCampaignToUserAsync(userId, campaignId);

            return Ok(campaignResponse);
        }





        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> UpdateCampaignAsync([FromRoute(Name = "id")] Guid id,
            [FromBody] UpdateCampaignRequestDto updateCampaignRequestDto)
        {
            await _manager.CampaignService.UpdateCampaignAsync(id, updateCampaignRequestDto, false);
            return NoContent();
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeleteCampaignAsync([FromRoute(Name = "id")] Guid id)
        {
            await _manager.CampaignService.DeleteCampaignAsync(id, false);
            return NoContent();
        }
    }
}
