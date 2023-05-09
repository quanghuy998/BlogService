using BlogService.Domain.Aggregates.Roles;
using BlogService.Domain.Aggregates.Users;
using BlogService.Domain.SeedWork;
using System.Linq.Expressions;

namespace BlogService.Infrastructure.Domain.Specifications
{
    public class GetUserSpecification : BaseSpecification<User>
    {
        public GetUserSpecification(Expression<Func<User, bool>> expression) : base(expression)
        {
            Includes.Add(x => x.UserClaims);
            Includes.Add(x => x.UserRoles);
        }
    }
}
