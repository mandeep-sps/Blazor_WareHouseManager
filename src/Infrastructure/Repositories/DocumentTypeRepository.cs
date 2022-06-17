using WarehouseManger.Application.Interfaces.Repositories;
using WarehouseManger.Domain.Entities.Misc;

namespace WarehouseManger.Infrastructure.Repositories
{
    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly IRepositoryAsync<DocumentType, int> _repository;

        public DocumentTypeRepository(IRepositoryAsync<DocumentType, int> repository)
        {
            _repository = repository;
        }
    }
}