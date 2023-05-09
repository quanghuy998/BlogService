using BlogService.Domain.Aggregates.Tags;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BlogService.Infrastructure.Database.EntityTypeConfigurations
{
    internal class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(k => k.Slug);
            builder.Property(k => k.Title);
            builder.Property(k => k.Content);
        }
    }
}
