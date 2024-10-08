using AutoMapper;
using CarRental.Entities.DataTransferObjects.ReviewDTOs;
using CarRental.Entities.Models;
using CarRental.Entities.RequestFeatures;
using CarRental.Repositories.Contracts;
using CarRental.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Concretes
{
    public class ReviewService : IReviewService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public ReviewService(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<GetReviewResponseDto> CreateReviewAsync(CreateReviewRequestDto createReviewRequestDto)
        {
            if (createReviewRequestDto is null)
                throw new ArgumentNullException(nameof(createReviewRequestDto));

            var review = _mapper.Map<Review>(createReviewRequestDto);

            _manager.Review.CreateReview(review);

            await _manager.SaveAsync();

            var reviewResponse = _mapper.Map<GetReviewResponseDto>(review);

            return reviewResponse;
        }

        public async Task DeleteReviewAsync(Guid id, bool isTraceable)
        {
            var entity = await _manager.Review.GetReviewByIdAsync(id, isTraceable);

            if (entity is null)
                throw new Exception($"Review with id:{id} could not found");

            _manager.Review.DeleteReview(entity);
            await _manager.SaveAsync();
        }


        public async Task<(IEnumerable<GetReviewWithDetailsResponseDto> reviews, MetaData metaData)> GetAllReviewsAsync(ReviewParameters reviewParameters, bool isTraceable)
        {
            var reviewsWithMetaData = await _manager
                .Review
                .GetAllReviewsAsync(reviewParameters,isTraceable);

            var reviewsResponse = _mapper.Map<IEnumerable<GetReviewWithDetailsResponseDto>>(reviewsWithMetaData);

            return (reviews : reviewsResponse, metaData : reviewsWithMetaData.MetaData);
        }

        public async Task<GetReviewResponseDto> GetReviewByIdAsync(Guid id, bool trackChanges)
        {
            var review = await _manager.Review.GetReviewByIdAsync(id, trackChanges);

            if (review is null)
                throw new Exception($"Review with id:{id} could not found");

            var reviewResponse = _mapper.Map<GetReviewResponseDto>(review);

            return reviewResponse;
        }

        public async Task UpdateReviewAsync(Guid id, UpdateReviewRequestDto updateReviewRequestDto, bool trackChanges)
        {
            var entity = await _manager.Review.GetReviewByIdAsync(id, trackChanges);
            if (entity is null)
                throw new Exception($"Review with id:{id} could not found.");


            entity = _mapper.Map<Review>(updateReviewRequestDto);
           

            _manager.Review.UpdateReview(entity);
            await _manager.SaveAsync();


        }
    }
}
