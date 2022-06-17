using WarehouseManger.Shared.Wrapper;
using System.Threading.Tasks;
using WarehouseManger.Application.Features.Dashboards.Queries.GetData;

namespace WarehouseManger.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}