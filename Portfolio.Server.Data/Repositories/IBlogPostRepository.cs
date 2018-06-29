using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Portfolio.Server.Data.Model;

namespace Portfolio.Server.Data.Repositories
{
    public interface IBlogPostRepository
    {
        Task<Guid> Add(BlogPost entity);
        Task Delete(BlogPost entity);
        Task<List<BlogPost>> GetAll();
        Task<BlogPost> GetById(Guid id);
        Task Update(BlogPost entity);
        Task<Author> GetAuthorById(Guid id);
        Task<Author> GetFirstAuthor();
        Task<IEnumerable<Tag>> GetTagsById(List<Guid> tagIds);
    }
}