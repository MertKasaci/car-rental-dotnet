using CarRental.Entities.DataTransferObjects.BrandDTOs;
using CarRental.Entities.DataTransferObjects.ModelDTOs;
using CarRental.Entities.Enums;
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
    [Route("api/models")]
    public class ModelsController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public ModelsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllModelAsync([FromQuery] ModelParameters modelParameters)
        {
            var pagedModelsResponse = await _manager
                .ModelService
                .GetAllModelsAsync(modelParameters, false);

            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(pagedModelsResponse.metaData));

            return Ok(pagedModelsResponse.models);

        }

        [HttpGet("{transmissionType}")]
        public async Task<IActionResult> GetAllModelByTransmissionTypeAsync([FromRoute(Name = "transmissionType")] TransmissionType transmissionType )
        {
            var modelsByTransmissionType = await _manager.ModelService.GetModelsByTransmissionTypeAsync(transmissionType,false);
            return Ok(modelsByTransmissionType);

        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetModelByIdAsync([FromRoute(Name = "id")] Guid id)
        {
            var model = await _manager.ModelService.GetModelByIdAsync(id, false);
            return Ok(model);

        }

        [HttpPost]
        public async Task<IActionResult> CreateModelAsync([FromBody] CreateModelRequestDto createModelRequestDto)
        {
            var model = await _manager.ModelService.CreateModelAsync(createModelRequestDto);
            return StatusCode(201, model);
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> UpdateModelAsync([FromRoute(Name = "id")] Guid id,
            [FromBody] UpdateModelRequestDto updateModelRequestDto)
        {
            await _manager.ModelService.UpdateModelAsync(id, updateModelRequestDto, false);
            return NoContent();
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeleteBrandAsync([FromRoute(Name = "id")] Guid id)
        {
            await _manager.ModelService.DeleteModelAsync(id, false);
            return NoContent();
        }



    }
}

