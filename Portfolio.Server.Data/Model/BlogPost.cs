using System;
using System.Collections.Generic;

namespace Portfolio.Server.Data.Model
{
    public class BlogPost: Entity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }
        public Author Author { get; set; }
        public ICollection<BlogPostTag> BlogPostTags { get; set; }
    }
}
