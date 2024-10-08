using CarRental.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;

namespace CarRental.Repositories.EFCore.Extensions
{
    public static class ReviewRepositoryExtensions
    {
        public static IQueryable<Review> Sort(
           this IQueryable<Review> vehicles,
           string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return vehicles.OrderBy(r => r.Id);

            var orderQuery = OrderQueryBuilder
                .CreateOrderQuery<Review>(orderByQueryString);

            if (orderQuery is null)
                return vehicles.OrderBy(r => r.Id);

            return vehicles.OrderBy(orderQuery);
        }
    }
}
