using CarRental.Entities.DataTransferObjects.BrandDTOs;
using CarRental.Entities.Models;
using CarRental.Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Contracts
{
    public interface IBrandService
    {
        Task<(IEnumerable<GetBrandResponseDto> brands, MetaData metaData)> GetAllBrandsAsync(BrandParameters brandParameters,bool isTraceable);
        Task<GetBrandResponseDto> GetBrandByIdAsync (Guid id, bool isTraceable);
        Task<GetBrandResponseDto> CreateBrandAsync(CreateBrandRequestDto createBrandRequestDto);
        Task UpdateBrandAsync(Guid id, UpdateBrandRequestDto updateBrandRequestDto, bool isTraceable);
        Task DeleteBrandAsync(Guid id, bool isTraceable);
    }
}
