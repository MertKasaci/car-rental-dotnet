using CarRental.Entities.DataTransferObjects.BrandDTOs;
using CarRental.Entities.Models;
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
    [Route("api/brands")]
    public class BrandsController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public BrandsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBrandsAsync([FromQuery]BrandParameters brandParameters)
        {
            var pagedBrandsResponse = await _manager
               .BrandService
               .GetAllBrandsAsync(brandParameters, false);

            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(pagedBrandsResponse.metaData));

            return Ok(pagedBrandsResponse.brands);

        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetBrandByIdAsync([FromRoute(Name = "id")] Guid id)
        {
            var brand = await _manager.BrandService.GetBrandByIdAsync(id, false);
            return Ok(brand);

        }

        [HttpPost]
        public async Task<IActionResult> CreateBrandAsync([FromBody] CreateBrandRequestDto createBrandRequestDto)
        {
            var brand = await _manager.BrandService.CreateBrandAsync(createBrandRequestDto);
            return StatusCode(201, brand);
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> UpdateBrandAsync([FromRoute(Name = "id")] Guid id ,
            [FromBody]UpdateBrandRequestDto updateBrandRequestDto)
        {
            await _manager.BrandService.UpdateBrandAsync(id,updateBrandRequestDto,false);
            return NoContent();
        }
        
        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeleteBrandAsync([FromRoute(Name = "id")] Guid id )
        {
            await _manager.BrandService.DeleteBrandAsync(id,false);
            return NoContent();
        }


        
    }
}
