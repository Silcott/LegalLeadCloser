using AutoMapper;
using LLC.Application.Responses.Identity;
using Microsoft.AspNetCore.Identity;

namespace LLC.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, IdentityRole>().ReverseMap();
        }
    }
}