using AutoMapper;
using WarehouseManger.Application.Interfaces.Chat;
using WarehouseManger.Application.Models.Chat;
using WarehouseManger.Infrastructure.Models.Identity;

namespace WarehouseManger.Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<BlazorHeroUser>>().ReverseMap();
        }
    }
}