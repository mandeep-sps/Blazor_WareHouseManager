using AutoMapper;
using WarehouseManger.Application.Requests.Identity;
using WarehouseManger.Application.Responses.Identity;

namespace WarehouseManger.Client.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<PermissionResponse, PermissionRequest>().ReverseMap();
            CreateMap<RoleClaimResponse, RoleClaimRequest>().ReverseMap();
        }
    }
}