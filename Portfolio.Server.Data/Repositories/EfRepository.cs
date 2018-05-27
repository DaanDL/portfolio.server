using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Server.Data.Model;

namespace Portfolio.Server.Data.Repositories
{
    public abstract class EfRepository<TContext, T> : IRepository<T> 
        where T: Entity
        where TContext: DbContext
    {
        protected readonly TContext Context;

        protected EfRepository(TContext context)
        {
            Context = context;
        }
        public async Task<Guid> Add(T entity)
        {
            entity.Id = Guid.NewGuid();
            Context.Set<T>().Add(entity);
            await Context.SaveChangesAsync();
            return entity.Id;
        }

        public async Task Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
            await Context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAll()
        {
            return  await Context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(Guid id)
        {
            return await Context.Set<T>().FindAsync(id);
        }

        public async  Task Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            await Context.SaveChangesAsync();
        }
    }
}
