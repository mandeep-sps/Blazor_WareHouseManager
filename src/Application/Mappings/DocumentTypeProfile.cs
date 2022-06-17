using AutoMapper;
using WarehouseManger.Application.Features.DocumentTypes.Commands.AddEdit;
using WarehouseManger.Application.Features.DocumentTypes.Queries.GetAll;
using WarehouseManger.Application.Features.DocumentTypes.Queries.GetById;
using WarehouseManger.Domain.Entities.Misc;

namespace WarehouseManger.Application.Mappings
{
    public class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
            CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
            CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
        }
    }
}