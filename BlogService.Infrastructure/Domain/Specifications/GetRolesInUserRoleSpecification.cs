using BlogService.Domain.Aggregates.UserRoles;
using BlogService.Domain.SeedWork;
using System.Linq.Expressions;

namespace BlogService.Infrastructure.Domain.Specifications
{
    public class GetRolesInUserRoleSpecification : BaseSpecification<UserRole>
    {
        public GetRolesInUserRoleSpecification(Expression<Func<UserRole, bool>> expression) : base(expression)
        {
            Includes.Add(x => x.Role);
        }
    }
}
