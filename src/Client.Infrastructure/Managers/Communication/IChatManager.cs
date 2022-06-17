using WarehouseManger.Application.Models.Chat;
using WarehouseManger.Application.Responses.Identity;
using WarehouseManger.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using WarehouseManger.Application.Interfaces.Chat;

namespace WarehouseManger.Client.Infrastructure.Managers.Communication
{
    public interface IChatManager : IManager
    {
        Task<IResult<IEnumerable<ChatUserResponse>>> GetChatUsersAsync();

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> chatHistory);

        Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string cId);
    }
}