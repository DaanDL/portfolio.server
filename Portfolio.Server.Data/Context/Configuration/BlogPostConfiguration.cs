using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Server.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Server.Data.Context.Configuration
{
    public class BlogPostConfiguration : IEntityTypeConfiguration<BlogPostTag>
    {
        public void Configure(EntityTypeBuilder<BlogPostTag> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
            builder.Property(x => x.DateAdded).IsRequired().HasDefaultValue(DateTime.UtcNow);
            builder.Property(x => x.DateUpdated).IsRequired().HasDefaultValue(DateTime.UtcNow);
            
        }
    }
}
