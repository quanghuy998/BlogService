using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BlogService.Domain.Aggregates.Categories;

namespace BlogService.Infrastructure.Database.EntityTypeConfigurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Slug).IsRequired();
            builder.Property(p => p.ParentId).IsRequired();
            builder.Property(p => p.Content).IsRequired();
            builder.Property(p => p.Title).IsRequired();
        }
    }
}
