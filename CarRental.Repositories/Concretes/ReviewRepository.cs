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
    public class ReviewRepository : RepositoryBase<Review>, IReviewRepository
    {
        public ReviewRepository(CarRentalContext context) : base(context)
        {
        }

        public void CreateReview(Review review) =>
            Create(review);
       

        public void DeleteReview(Review review) =>
            Delete(review);


        public async Task<PagedList<Review>> GetAllReviewsAsync(ReviewParameters reviewParameters, bool isTraceable)
        {

            var reviews = await FindAll(isTraceable)
              .Sort(reviewParameters.OrderBy)
              .Include(r => r.Reservation)
              .ThenInclude(r => r.User)
              .ToListAsync();

           return PagedList<Review>
                       .ToPagedList(reviews,
                       reviewParameters.PageNumber,
                       reviewParameters.PageSize);
        }
            


        public async Task<Review> GetReviewByIdAsync(Guid id, bool isTraceable) =>
            await FindByCondition((rv => rv.Id == id), isTraceable)
            .FirstOrDefaultAsync();
        

        public void UpdateReview(Review review) =>
            Update(review);
        
    }
}
