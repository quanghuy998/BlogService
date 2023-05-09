using BlogService.Domain.Aggregates.Roles;
using BlogService.Domain.Aggregates.UserRoles;
using BlogService.Domain.Aggregates.Users;
using BlogService.Domain.SeedWork;
using BlogService.Infrastructure.Database;
using BlogService.Infrastructure.Domain.Specifications;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BlogService.Infrastructure.Domain.Repositories
{
    internal class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AuthDbContext context) : base(context)
        {
        }

        public override Task<User> FindOneAsync(Expression<Func<User, bool>> expression, CancellationToken cancellationToken)
        {
            var specification = new GetUserSpecification(expression);
            return base.FindOneAsync(specification, cancellationToken);
        }

        public async Task<List<string>> GetUserClaims(Expression<Func<User, bool>> expression, CancellationToken cancellationToken)
        {
            var user = await DbContext.Set<User>()
                .Include(x => x.UserClaims)
                .Include(x => x.UserRoles)
                .ThenInclude(x => x.Role)
                .FirstOrDefaultAsync(expression, cancellationToken);

            return user == null ? null : user.GetFullClaims();
        }
    }
}
