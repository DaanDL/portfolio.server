using System;
using System.Collections.Generic;

namespace Portfolio.Server.Data.Model
{
    public class Tag:Entity
    {
        public string TagName { get; set; }
        public ICollection<BlogPostTag> BlogPostTags { get; set; }
    }
}
