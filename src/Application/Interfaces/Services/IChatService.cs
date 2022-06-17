using WarehouseManger.Application.Responses.Identity;
using WarehouseManger.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using WarehouseManger.Application.Interfaces.Chat;
using WarehouseManger.Application.Models.Chat;

namespace WarehouseManger.Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}