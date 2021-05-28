using AutoMapper;
using LLC.Application.Features.Brands.Commands.AddEdit;
using LLC.Application.Features.Brands.Queries.GetAll;
using LLC.Application.Features.Brands.Queries.GetById;
using LLC.Domain.Entities.Catalog;

namespace LLC.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}