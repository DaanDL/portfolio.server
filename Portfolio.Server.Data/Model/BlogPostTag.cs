using System;

namespace Portfolio.Server.Data.Model
{
    public class BlogPostTag
    {
        public Guid BlogPostId { get; set; }
        public Guid TagId { get; set; }
        public BlogPost BlogPost { get; set; }
        public Tag Tag { get; set; }
    }
}
