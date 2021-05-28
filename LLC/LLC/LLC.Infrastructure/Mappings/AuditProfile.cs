using AutoMapper;
using LLC.Application.Models.Audit;
using LLC.Application.Responses.Audit;

namespace LLC.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}