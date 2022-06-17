using WarehouseManger.Application.Interfaces.Repositories;
using WarehouseManger.Domain.Entities.Catalog;

namespace WarehouseManger.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IRepositoryAsync<Brand, int> _repository;

        public BrandRepository(IRepositoryAsync<Brand, int> repository)
        {
            _repository = repository;
        }
    }
}