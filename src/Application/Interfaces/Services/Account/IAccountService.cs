using WarehouseManger.Application.Interfaces.Common;
using WarehouseManger.Application.Requests.Identity;
using WarehouseManger.Shared.Wrapper;
using System.Threading.Tasks;

namespace WarehouseManger.Application.Interfaces.Services.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}