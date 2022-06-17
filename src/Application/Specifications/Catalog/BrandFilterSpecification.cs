using WarehouseManger.Application.Specifications.Base;
using WarehouseManger.Domain.Entities.Catalog;

namespace WarehouseManger.Application.Specifications.Catalog
{
    public class BrandFilterSpecification : HeroSpecification<Brand>
    {
        public BrandFilterSpecification(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                Criteria = p => p.Name.Contains(searchString) || p.Description.Contains(searchString);
            }
            else
            {
                Criteria = p => true;
            }
        }
    }
}
