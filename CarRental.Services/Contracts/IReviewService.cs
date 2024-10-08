using CarRental.Entities.DataTransferObjects.ReviewDTOs;
using CarRental.Entities.DataTransferObjects.VehicleDTOs;
using CarRental.Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Contracts
{
    public interface IReviewService
    {
        Task<(IEnumerable<GetReviewWithDetailsResponseDto> reviews, MetaData metaData)> GetAllReviewsAsync(ReviewParameters reviewParameters, bool isTraceable);
        Task<GetReviewResponseDto> GetReviewByIdAsync(Guid id, bool isTraceable);
        Task<GetReviewResponseDto> CreateReviewAsync(CreateReviewRequestDto createReviewRequestDto);
        Task UpdateReviewAsync(Guid id, UpdateReviewRequestDto updateReviewRequestDto, bool isTraceable);
        Task DeleteReviewAsync(Guid id, bool isTraceable);
    }
}
