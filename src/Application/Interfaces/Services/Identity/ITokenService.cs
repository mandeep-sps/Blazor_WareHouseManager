using WarehouseManger.Application.Interfaces.Common;
using WarehouseManger.Application.Requests.Identity;
using WarehouseManger.Application.Responses.Identity;
using WarehouseManger.Shared.Wrapper;
using System.Threading.Tasks;

namespace WarehouseManger.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}