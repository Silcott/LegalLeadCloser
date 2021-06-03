using AutoMapper;
using LLC.Application.Features.Products.Commands.AddEdit;
using LLC.Domain.Entities.Catalog;

namespace LLC.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}