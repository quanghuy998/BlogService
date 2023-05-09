using BlogService.Domain.SeedWork;

namespace BlogService.Domain.Aggregates.Posts
{
    public class PostCategory : Entity
    {
        public int PostId { get; }
        public int CategoryId { get; }

        public PostCategory(int postId, int categoryId)
        {
            PostId = postId;
            CategoryId = categoryId;
        }
    }
}
