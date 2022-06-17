using AutoMapper;
using WarehouseManger.Infrastructure.Models.Identity;
using WarehouseManger.Application.Responses.Identity;

namespace WarehouseManger.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, BlazorHeroRole>().ReverseMap();
        }
    }
}