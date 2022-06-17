using AutoMapper;
using WarehouseManger.Application.Features.Documents.Commands.AddEdit;
using WarehouseManger.Application.Features.Documents.Queries.GetById;
using WarehouseManger.Domain.Entities.Misc;

namespace WarehouseManger.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
            CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
        }
    }
}