using CarRental.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;


namespace CarRental.Repositories.EFCore.Extensions
{
    public static class CampaignRepositoryExtensions
    {
        public static IQueryable<Campaign> Sort(
            this IQueryable<Campaign> vehicles,
            string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return vehicles.OrderBy(v => v.Id);

            var orderQuery = OrderQueryBuilder
                .CreateOrderQuery<Campaign>(orderByQueryString);

            if (orderQuery is null)
                return vehicles.OrderBy(v => v.Id);

            return vehicles.OrderBy(orderQuery);
        }
    }
}
