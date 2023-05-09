using BlogService.Domain.SeedWork;

namespace BlogService.Domain.Aggregates.Posts
{
    public class Post : Aggregate
    {
        public int ParentId { get; private set; }
        public string Slug { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public string Summary { get; private set; }
        public int Status { get; private set; }
        public DateTime CreatedTime { get; private set; }
        public DateTime ModifiedTime { get; private set; }
        
        public List<PostTag> PostTags { get; private set; }
        public List<PostCategory> PostCategories { get; private set; }
        public List<PostComment> PostComments { get; private set; }

        public Post (int parentId, string title, string slug, string summary, int status, string content, DateTime createdTime, DateTime modifiedTime, IEnumerable<PostTag> postTags, IEnumerable<PostCategory> postCategories, IEnumerable<PostComment> postComments)
        {
            ParentId = parentId;
            Title = title;
            Slug = slug;
            Summary = summary;
            Status = status;
            Content = content;
            CreatedTime = createdTime;
            ModifiedTime = modifiedTime;
            PostTags = postTags;
            PostCategories = postCategories;
            PostComments = postComments;
        }

        public void UpdatePost(int parentId, string title, string slug, string summary, int status, string content, DateTime createdTime, DateTime modifiedTime, IEnumerable<PostTag> postTags, IEnumerable<PostCategory> postCategories, IEnumerable<PostComment> postComments)
        {
            ParentId = parentId;
            Title = title;
            Slug = slug;
            Summary = summary;
            Status = status;
            Content = content;
            CreatedTime = createdTime;
            ModifiedTime = modifiedTime;
            PostTags = postTags;
            PostCategories = postCategories;
            PostComments = postComments;
        }
    }
}
