using AutoMapper;
using CarRental.Entities.DataTransferObjects.BrandDTOs;
using CarRental.Entities.Models;
using CarRental.Entities.RequestFeatures;
using CarRental.Repositories.Contracts;
using CarRental.Services.Contracts;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Concretes
{
    public class BrandService : IBrandService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public BrandService(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<GetBrandResponseDto> CreateBrandAsync(CreateBrandRequestDto createBrandRequestDto)
        {
            if(createBrandRequestDto is null)
                throw new ArgumentNullException(nameof(createBrandRequestDto));

            var brand = _mapper.Map<Brand>(createBrandRequestDto);

            _manager.Brand.CreateBrand(brand);

            await _manager.SaveAsync();

            var brandResponse = _mapper.Map<GetBrandResponseDto>(brand);

            return brandResponse;
        }

        public async Task DeleteBrandAsync(Guid id, bool isTraceable)
        {
            var entity = await _manager.Brand.GetBrandByIdAsync(id,isTraceable);

            if (entity is null)
                throw new Exception($"Brand with id:{id} could not found");

            _manager.Brand.DeleteBrand(entity);
            await _manager.SaveAsync();
        }

        public async Task<(IEnumerable<GetBrandResponseDto> brands, MetaData metaData)> GetAllBrandsAsync(BrandParameters brandParameters, bool isTraceable)
        {
            var brandsWithMetaData = await _manager.Brand
                .GetAllBrandsAsync(brandParameters, isTraceable);

            var brandsResponse = _mapper.Map<IEnumerable<GetBrandResponseDto>>(brandsWithMetaData);

            return (brands : brandsResponse, metaData : brandsWithMetaData.MetaData);
                
        }

        public async Task<GetBrandResponseDto> GetBrandByIdAsync(Guid id, bool trackChanges)
        {
            var brand = await _manager.Brand.GetBrandByIdAsync(id, trackChanges);

            if(brand is null)
                throw new Exception($"Brand with id:{id} could not found");

            var brandResponse = _mapper.Map<GetBrandResponseDto>(brand);

            return brandResponse;
        }

        public async Task UpdateBrandAsync(Guid id, UpdateBrandRequestDto updateBrandRequestDto, bool trackChanges)
        {
            var entity = await _manager.Brand.GetBrandByIdAsync(id, trackChanges);
            if(entity is null)
                throw new Exception($"Brand with id:{id} could not found.");


            entity = _mapper.Map<Brand>(updateBrandRequestDto);
;

            _manager.Brand.UpdateBrand(entity);
            await _manager.SaveAsync();

            
        }
    }
}
