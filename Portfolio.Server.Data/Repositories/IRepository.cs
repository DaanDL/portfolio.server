using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Portfolio.Server.Data.Repositories
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(Guid id);
        Task<Guid> Add(T entity);
        Task Delete(T entity);
        Task Update(T entity);
    }
}
