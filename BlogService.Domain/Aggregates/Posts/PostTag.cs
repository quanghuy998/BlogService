using BlogService.Domain.SeedWork;

namespace BlogService.Domain.Aggregates.Posts
{
    public class PostTag : Entity
    {
        public int PostId { get; }
        public int TagId { get; }
    }
}
