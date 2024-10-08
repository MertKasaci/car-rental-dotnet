using CarRental.Entities.Enums;
using CarRental.Entities.Models;
using CarRental.Entities.RequestFeatures;
using CarRental.Repositories.Contracts;
using CarRental.Repositories.EFCore;
using CarRental.Repositories.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.Concretes
{
    public class ModelRepository : RepositoryBase<Model>, IModelRepository
    {
        public ModelRepository(CarRentalContext context) : base(context)
        {
        }

        public void CreateModel(Model model) =>
            Create(model);
        

        public void DeleteModel(Model model) =>
            Delete(model);

        public async Task<PagedList<Model>> GetAllModelsAsync(
            ModelParameters modelParameters,
            bool isTraceable)
        { 
         var models = await FindAll(isTraceable)
            .FilterModels(
               modelParameters.Capacity,
               modelParameters.FuelType,
               modelParameters.LuggageCapacity,
               modelParameters.TransmissionType
              )
            .OrderBy(v => v.Id)
            .ToListAsync();

            return PagedList<Model>
                .ToPagedList(models,
                modelParameters.PageNumber,
                modelParameters.PageSize);

        }
        public async Task<Model> GetModelByIdAsync(Guid id, bool isTraceable) =>
          await FindByCondition((m => m.Id == id), isTraceable)
            .FirstOrDefaultAsync();

        public async Task<IEnumerable<Model>> GetModelsByTransmissionTypeAsync(TransmissionType transmissionType, bool isTraceable) =>
           await FindByCondition((m => m.TransmissionType == transmissionType), isTraceable)
                .ToListAsync();

        

        public void UpdateModel(Model model) =>
            Update(model);
        
    }
}
