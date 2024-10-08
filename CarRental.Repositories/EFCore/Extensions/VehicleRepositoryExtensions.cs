using CarRental.Entities.Enums;
using CarRental.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;

namespace CarRental.Repositories.EFCore.Extensions
{
    public static class VehicleRepositoryExtensions
    {

         public static IQueryable<Vehicle> FilterVehicles(
             this IQueryable<Vehicle>vehicles ,
             decimal? minDailyPrice, 
             decimal? maxDailyPrice,
             int? year,
             VehicleColor? color,
             VehicleStatus? status
             )
         {
            if (year.HasValue)
                vehicles = vehicles.Where(v => v.Year == year.Value);

            if (color.HasValue)
                vehicles = vehicles.Where(v => v.Color == color.Value);

            if(minDailyPrice.HasValue)
                vehicles = vehicles.Where(v => v.DailyPrice >= minDailyPrice.Value);

            if (maxDailyPrice.HasValue)
                vehicles = vehicles.Where(v => v.DailyPrice <= maxDailyPrice.Value);

            if (status.HasValue)
                vehicles = vehicles.Where(v => v.Status == status.Value);






                return vehicles; 
         }

         public static IQueryable<Vehicle> Sort(
            this IQueryable<Vehicle> vehicles , 
            string orderByQueryString)
        {
            if(string.IsNullOrWhiteSpace(orderByQueryString))
               return vehicles.OrderBy(v => v.Id);

            var orderQuery = OrderQueryBuilder
                .CreateOrderQuery<Vehicle>(orderByQueryString);
             
           if(orderQuery is null)
                   return vehicles.OrderBy(v => v.Id);

           return vehicles.OrderBy(orderQuery);
        }
    }
}
