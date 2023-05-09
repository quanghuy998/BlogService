using BlogService.Domain.SeedWork;

namespace BlogService.Domain.Aggregates.Posts
{
    public class PostComment : Entity
    {
        public int PostId { get; }
        public int ParentId { get; }
        public int AuthorId { get; }
        public string Content { get; }
        public DateTime CreatedTime { get; }
        public DateTime Modifiedtime { get; }
    }
}
