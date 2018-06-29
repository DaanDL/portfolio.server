using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Portfolio.Server.Data.Context;
using Portfolio.Server.Data.Model;

namespace Portfolio.Server.Data.Repositories
{
    public class BlogPostRepository : EfRepository<BlogPostContext,BlogPost>, IBlogPostRepository
    {

        public BlogPostRepository(BlogPostContext context): base(context)
        {
        }

        public async Task<Author> GetAuthorById(Guid id)
        {
            var author = await Context.Authors.SingleOrDefaultAsync(x => x.Id == id);
            return author;
        }

        public async Task<Author> GetFirstAuthor()
        {
            var author = await Context.Authors.FirstOrDefaultAsync();
            return author;
        }

        public async Task<IEnumerable<Tag>> GetTagsById(List<Guid> tagIds)
        {
            var tags = await Context.Tags.Where(x => tagIds.Contains(x.Id)).ToListAsync();
            return tags;
        }
    }
}
