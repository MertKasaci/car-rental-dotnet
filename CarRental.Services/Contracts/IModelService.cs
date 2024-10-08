using CarRental.Entities.DataTransferObjects.BrandDTOs;
using CarRental.Entities.DataTransferObjects.ModelDTOs;
using CarRental.Entities.Enums;
using CarRental.Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Contracts
{
    public interface IModelService
    {
        Task<(IEnumerable<GetModelResponseDto> models, MetaData metaData)> GetAllModelsAsync(ModelParameters modelParameters, bool isTraceable);
        Task<GetModelResponseDto> GetModelByIdAsync(Guid id, bool isTraceable);
        Task<IEnumerable<GetModelResponseDto>> GetModelsByTransmissionTypeAsync(TransmissionType transmissionType, bool isTraceable);
        Task<GetModelResponseDto> CreateModelAsync(CreateModelRequestDto createModelRequestDto);
        Task UpdateModelAsync(Guid id, UpdateModelRequestDto updateModelRequestDto, bool isTraceable);
        Task DeleteModelAsync(Guid id, bool isTraceable);
    }
}
