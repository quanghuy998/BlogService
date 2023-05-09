using BlogService.Domain.Aggregates.UserRoles;
using BlogService.Domain.Aggregates.Users;
using BlogService.Domain.SeedWork;
using System.Linq.Expressions;

namespace BlogService.Infrastructure.Domain.Specifications
{
    public class GetUserRoleSpecification : BaseSpecification<UserRole>
    {
        public GetUserRoleSpecification(Expression<Func<UserRole, bool>> expression) : base(expression)
        {
            Includes.Add(x => x.User);
            Includes.Add(x => x.Role);
        }
    }
}
