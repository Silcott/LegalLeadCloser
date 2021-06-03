using AutoMapper;
using LLC.Application.Models.Identity;
using LLC.Application.Responses.Identity;

namespace LLC.Infrastructure.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserResponse, LLCUser>().ReverseMap();
            CreateMap<ChatUserResponse, LLCUser>().ReverseMap()
                .ForMember(dest => dest.EmailAddress, source => source.MapFrom(source => source.Email)); //Specific Mapping
        }
    }
}