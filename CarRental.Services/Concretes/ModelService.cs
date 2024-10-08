using AutoMapper;
using CarRental.Entities.DataTransferObjects.BrandDTOs;
using CarRental.Entities.DataTransferObjects.ModelDTOs;
using CarRental.Entities.Enums;
using CarRental.Entities.Models;
using CarRental.Entities.RequestFeatures;
using CarRental.Repositories.Contracts;
using CarRental.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Concretes
{
    public class ModelService : IModelService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public ModelService(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<GetModelResponseDto> CreateModelAsync(CreateModelRequestDto createModelRequestDto)
        {
            if(createModelRequestDto is null)
                throw new ArgumentNullException(nameof(createModelRequestDto));

            var model = _mapper.Map<Model>(createModelRequestDto);

            _manager.Model.CreateModel(model);
            await _manager.SaveAsync();

            var modelResponse = _mapper.Map<GetModelResponseDto>(model);

            return modelResponse;

        }

        public async Task DeleteModelAsync(Guid id, bool isTraceable)
        {
            var model = await _manager.Model.GetModelByIdAsync(id,isTraceable);

            if (model is null)
                throw new ArgumentNullException(nameof(model));

            _manager.Model.DeleteModel(model);
            await _manager.SaveAsync(); 

        }

        public async Task<(IEnumerable<GetModelResponseDto> models , MetaData metaData)> GetAllModelsAsync(ModelParameters modelParameters, bool isTraceable)
        {
            var modelsWithMetaData = await _manager
                .Model.GetAllModelsAsync(modelParameters, isTraceable);

            var modelsResponse = _mapper.
                Map<IEnumerable<GetModelResponseDto>>(modelsWithMetaData);

            return (modelsResponse, modelsWithMetaData.MetaData);
        }

        public async Task<GetModelResponseDto> GetModelByIdAsync(Guid id, bool isTraceable)
        {
            var model = await _manager.Model.GetModelByIdAsync(id,isTraceable);
            if (model is null) 
                throw new ArgumentNullException( nameof(model));

            var modelResponse = _mapper.Map<GetModelResponseDto>(model);

            return modelResponse;
        }

        public async Task<IEnumerable<GetModelResponseDto>> GetModelsByTransmissionTypeAsync(TransmissionType transmissionType, bool isTraceable)
        {
            var modelsByTransmissonType = await _manager.Model.GetModelsByTransmissionTypeAsync(transmissionType,isTraceable);

            var modelsResponseByTranmissionType = _mapper.Map<IEnumerable<GetModelResponseDto>>(modelsByTransmissonType);

            return modelsResponseByTranmissionType;
        }

        public async Task UpdateModelAsync(Guid id, UpdateModelRequestDto updateModelRequestDto, bool isTraceable)
        {
            var entity = await _manager.Model.GetModelByIdAsync(id,isTraceable);

            if(entity is null)
                throw new ArgumentNullException(nameof(entity));

            entity = _mapper.Map<Model>(updateModelRequestDto);

            _manager.Model.UpdateModel(entity);
            await _manager.SaveAsync(); 
        }
    }
}
