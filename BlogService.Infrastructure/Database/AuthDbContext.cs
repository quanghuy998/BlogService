using BlogService.Domain.Aggregates.Categories;
using BlogService.Domain.Aggregates.Posts;
using BlogService.Domain.Aggregates.Tags;
using Microsoft.EntityFrameworkCore;

namespace BlogService.Infrastructure.Database
{
    internal class AuthDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public AuthDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AuthDbContext).Assembly);
        }
    }
}
