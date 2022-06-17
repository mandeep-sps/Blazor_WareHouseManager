using AutoMapper;
using WarehouseManger.Infrastructure.Models.Audit;
using WarehouseManger.Application.Responses.Audit;

namespace WarehouseManger.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}