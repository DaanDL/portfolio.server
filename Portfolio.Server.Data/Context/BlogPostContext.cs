using Microsoft.EntityFrameworkCore;
using Portfolio.Server.Data.Context.Configuration;
using Portfolio.Server.Data.Model;

namespace Portfolio.Server.Data.Context
{
    public class BlogPostContext : DbContext, IBlogPostContext
    {
        public BlogPostContext(DbContextOptions<BlogPostContext> options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AuthorConfiguration());
            builder.ApplyConfiguration(new BlogPostConfiguration());
            builder.ApplyConfiguration(new BlogPostTagConfiguration());
            builder.ApplyConfiguration(new TagConfiguration());
        }
    }
}
