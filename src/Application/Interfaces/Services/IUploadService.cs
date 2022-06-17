using WarehouseManger.Application.Requests;

namespace WarehouseManger.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}