using System.Collections.Generic;

namespace Portfolio.Server.Data.Model
{
    public class Tag
    {
        public int Id { get; set; }
        public string TagName { get; set; }
        public ICollection<BlogPostTag> BlogPostTags { get; set; }
    }
}
