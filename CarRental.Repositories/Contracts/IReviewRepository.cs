using CarRental.Entities.Models;
using CarRental.Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.Contracts
{
    public interface IReviewRepository : IRepositoryBase<Review>
    {
        Task<PagedList<Review>> GetAllReviewsAsync(ReviewParameters reviewParameters,bool isTraceable);
        Task<Review> GetReviewByIdAsync(Guid id, bool isTraceable);
        void CreateReview(Review review);
        void UpdateReview(Review review);
        void DeleteReview(Review review);
    }
}
