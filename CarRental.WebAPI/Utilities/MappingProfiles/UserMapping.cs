using AutoMapper;
using CarRental.Entities.DataTransferObjects.UserDTOs;
using CarRental.Entities.Models;

namespace CarRental.WebAPI.Utilities.MappingProfiles
{
    public class UserMapping : Profile
    {
        public UserMapping()
        {
            CreateMap<UserRegisterDto, User>();
            CreateMap<User,GetUserDetailsResponseDto>();

            CreateMap<UpdateUserRequestDto,User>()
            .ForMember(dest => dest.NormalizedUserName, opt => opt.Ignore())
            .ForMember(dest => dest.NormalizedEmail, opt => opt.Ignore());
        }

    }
}
