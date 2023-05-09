using BlogService.Domain.Aggregates.Roles;
using BlogService.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace BlogService.Infrastructure.Domain.Repositories
{
    internal class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(AuthDbContext context) : base(context)
        {
        }
    }
}
