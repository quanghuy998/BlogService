using BlogService.Domain.Aggregates.Roles;
using BlogService.Domain.SeedWork;
using System.Linq.Expressions;

namespace BlogService.Infrastructure.Domain.Specifications
{
    public class GetRoleClaimsSpecification : BaseSpecification<Role>
    {
        public GetRoleClaimsSpecification(Expression<Func<Role, bool>> expression) : base(expression)
        {
            Includes.Add(x => x.RoleClaims);
        }
    }
}
