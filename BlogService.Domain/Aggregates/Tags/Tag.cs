using BlogService.Domain.Aggregates.Posts;
using BlogService.Domain.SeedWork;

namespace BlogService.Domain.Aggregates.Tags
{
    public class Tag : Aggregate
    {
        public string Title { get; }
        public string Slug { get; }
        public string Content { get; }

        public Tag (string title, string slug, string content)
        {
            Title = title;
            Slug = slug;
            Content = content;
        }
    }
}
