using AutoMapper;
using CarRental.Entities.DataTransferObjects.ReviewDTOs;
using CarRental.Entities.Models;

namespace CarRental.WebAPI.Utilities.MappingProfiles
{
    public class ReviewMapping : Profile
    {
        public ReviewMapping()
        {
            CreateMap<CreateReviewRequestDto, Review>();
            CreateMap<UpdateReviewRequestDto, Review>();
            CreateMap<Review, GetReviewResponseDto>();
            CreateMap<Review, GetReviewWithDetailsResponseDto>();
        }
    }
}
