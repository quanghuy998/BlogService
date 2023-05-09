using BlogService.Domain.Aggregates.Posts;
using BlogService.Domain.SeedWork;

namespace BlogService.Domain.Aggregates.Posts
{
    public interface IPostRepository : IBaseRepository<Post>
    {
    }
}
