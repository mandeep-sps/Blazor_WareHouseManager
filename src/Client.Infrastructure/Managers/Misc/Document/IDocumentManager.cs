using WarehouseManger.Application.Features.Documents.Commands.AddEdit;
using WarehouseManger.Application.Features.Documents.Queries.GetAll;
using WarehouseManger.Application.Requests.Documents;
using WarehouseManger.Shared.Wrapper;
using System.Threading.Tasks;
using WarehouseManger.Application.Features.Documents.Queries.GetById;

namespace WarehouseManger.Client.Infrastructure.Managers.Misc.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<GetDocumentByIdResponse>> GetByIdAsync(GetDocumentByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}