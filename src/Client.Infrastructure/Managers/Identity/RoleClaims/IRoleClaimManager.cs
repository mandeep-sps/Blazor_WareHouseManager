using System.Collections.Generic;
using System.Threading.Tasks;
using WarehouseManger.Application.Requests.Identity;
using WarehouseManger.Application.Responses.Identity;
using WarehouseManger.Shared.Wrapper;

namespace WarehouseManger.Client.Infrastructure.Managers.Identity.RoleClaims
{
    public interface IRoleClaimManager : IManager
    {
        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsAsync();

        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsByRoleIdAsync(string roleId);

        Task<IResult<string>> SaveAsync(RoleClaimRequest role);

        Task<IResult<string>> DeleteAsync(string id);
    }
}