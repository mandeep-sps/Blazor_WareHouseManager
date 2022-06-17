using WarehouseManger.Infrastructure.Models.Identity;
using WarehouseManger.Application.Specifications.Base;

namespace WarehouseManger.Infrastructure.Specifications
{
    public class UserFilterSpecification : HeroSpecification<BlazorHeroUser>
    {
        public UserFilterSpecification(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                Criteria = p => p.FirstName.Contains(searchString) || p.LastName.Contains(searchString) || p.Email.Contains(searchString) || p.PhoneNumber.Contains(searchString) || p.UserName.Contains(searchString);
            }
            else
            {
                Criteria = p => true;
            }
        }
    }
}