using BlogService.Domain.Aggregates.UserRoles;
using BlogService.Domain.SeedWork;
using BlogService.Infrastructure.Database;
using BlogService.Infrastructure.Domain.Specifications;
using System.Linq.Expressions;

namespace BlogService.Infrastructure.Domain.Repositories
{
    internal class UserRoleRepository : BaseRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(AuthDbContext context) : base(context)
        {
        }

        public override Task<IEnumerable<UserRole>> FindAllAsync(Expression<Func<UserRole, bool>> expression, CancellationToken cancellationToken)
        {
            var specification = new GetUserRoleSpecification(expression);
            return base.FindAllAsync(specification, cancellationToken);
        }
    }
}
