using AutoMapper;
using WarehouseManger.Application.Features.Brands.Commands.AddEdit;
using WarehouseManger.Application.Features.Brands.Queries.GetAll;
using WarehouseManger.Application.Features.Brands.Queries.GetById;
using WarehouseManger.Domain.Entities.Catalog;

namespace WarehouseManger.Application.Mappings
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