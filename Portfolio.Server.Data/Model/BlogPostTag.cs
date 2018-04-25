namespace Portfolio.Server.Data.Model
{
    public class BlogPostTag
    {
        public int BlogPostId { get; set; }
        public int TagId { get; set; }
        public BlogPostTag BlogPost { get; set; }
        public Tag Tag { get; set; }
    }
}
