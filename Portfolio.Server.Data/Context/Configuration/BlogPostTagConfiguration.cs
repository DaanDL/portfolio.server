using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Server.Data.Model;


namespace Portfolio.Server.Data.Context.Configuration
{
    public class BlogPostTagConfiguration : IEntityTypeConfiguration<BlogPostTag>
    {
        public void Configure(EntityTypeBuilder<BlogPostTag> builder)
        {
            builder.HasKey(x => new { x.BlogPostId, x.TagId });
            //builder.HasOne<BlogPost>().WithMany().HasForeignKey(x => x.BlogPostId);
            //builder.HasOne<Tag>().WithMany().HasForeignKey(x => x.TagId);
        }
    }
}
