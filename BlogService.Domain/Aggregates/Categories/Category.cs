using BlogService.Domain.SeedWork;

namespace BlogService.Domain.Aggregates.Categories
{
    public class Category : Aggregate
    {
        public int ParentId { get; }
        public string Title { get; }
        public string Slug { get; }
        public string Content { get; }

        public Category(int parentId, string title, string slug, string content)
        {
            ParentId = parentId;
            Title = title;
            Slug = slug;
            Content = content;
        }
    }
}
