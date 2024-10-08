using CarRental.Entities.Enums;
using CarRental.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.EFCore.Extensions
{
    public static class ModelRepositoryExtensions
    {
        

            public static IQueryable<Model> FilterModels(
                this IQueryable<Model> models,
                int? capacity,
                FuelType? fuelType,
                int? luggageCapacity,
                TransmissionType? transmissionType
                )
            {
                if (capacity.HasValue)
                    models = models.Where(m => m.Capacity == capacity.Value);

                if (fuelType.HasValue)
                    models = models.Where(m => m.FuelType == fuelType.Value);

                if (luggageCapacity.HasValue)
                    models = models.Where(m => m.LuggageCapacity == luggageCapacity.Value);

                if (transmissionType.HasValue)
                    models = models.Where(m => m.TransmissionType == transmissionType.Value);

                





                return models;
            }

        }
    
}
