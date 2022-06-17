using WarehouseManger.Application.Interfaces.Common;

namespace WarehouseManger.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}