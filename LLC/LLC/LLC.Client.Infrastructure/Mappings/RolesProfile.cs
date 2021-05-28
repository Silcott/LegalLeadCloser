using AutoMapper;
using LLC.Application.Requests.Identity;
using LLC.Application.Responses.Identity;

namespace LLC.Client.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<PermissionResponse, PermissionRequest>().ReverseMap();
            CreateMap<RoleClaimsResponse, RoleClaimsRequest>().ReverseMap();
        }
    }
}