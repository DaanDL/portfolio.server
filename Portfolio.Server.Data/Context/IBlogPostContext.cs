using Microsoft.EntityFrameworkCore;
using Portfolio.Server.Data.Model;

namespace Portfolio.Server.Data.Context
{
    public interface IBlogPostContext
    {
        DbSet<BlogPost> BlogPosts { get; set; }
        DbSet<Tag> Tags { get; set; }
        DbSet<Author> Authors { get; set; }
    }
}