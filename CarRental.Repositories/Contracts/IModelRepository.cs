using CarRental.Entities.Enums;
using CarRental.Entities.Models;
using CarRental.Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.Contracts
{
    public interface IModelRepository : IRepositoryBase<Model>
    {
        Task<PagedList<Model>> GetAllModelsAsync(ModelParameters modelParameters , bool isTraceable);
        Task<Model> GetModelByIdAsync(Guid id, bool isTraceable);
        Task<IEnumerable<Model>> GetModelsByTransmissionTypeAsync(TransmissionType transmissionType , bool isTraceable);
        void CreateModel(Model model);
        void UpdateModel(Model model);
        void DeleteModel(Model model);
    }
}
