using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BlogService.Domain.Aggregates.Posts;

namespace BlogService.Infrastructure.Database.EntityTypeConfigurations
{
    internal class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Slug);
            builder.Property(p => p.Title);
            builder.Property(p => p.Content);
            builder.Property(p => p.Summary);
            builder.Property(p => p.Status);
            builder.Property(p => p.ModifiedTime);
            builder.Property(p => p.CreatedTime);

            builder.OwnsMany<PostCategory>(own => own.PostCategories, entityBuilder =>
            {
                entityBuilder.HasKey(k => k.Id);
            });
        }
    }
}
