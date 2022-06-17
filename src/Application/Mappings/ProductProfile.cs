using AutoMapper;
using WarehouseManger.Application.Features.Products.Commands.AddEdit;
using WarehouseManger.Domain.Entities.Catalog;

namespace WarehouseManger.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}