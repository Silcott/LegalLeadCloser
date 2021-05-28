using AutoMapper;
using LLC.Application.Features.Documents.Commands.AddEdit;
using LLC.Domain.Entities;

namespace LLC.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
        }
    }
}