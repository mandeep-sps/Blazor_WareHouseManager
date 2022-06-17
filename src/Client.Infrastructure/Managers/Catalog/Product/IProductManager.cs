using WarehouseManger.Application.Features.Products.Commands.AddEdit;
using WarehouseManger.Application.Features.Products.Queries.GetAllPaged;
using WarehouseManger.Application.Requests.Catalog;
using WarehouseManger.Shared.Wrapper;
using System.Threading.Tasks;

namespace WarehouseManger.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}