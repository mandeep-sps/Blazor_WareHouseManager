using System.Collections.Generic;
using System.Threading.Tasks;
using WarehouseManger.Application.Interfaces.Common;
using WarehouseManger.Application.Requests.Identity;
using WarehouseManger.Application.Responses.Identity;
using WarehouseManger.Shared.Wrapper;

namespace WarehouseManger.Application.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}