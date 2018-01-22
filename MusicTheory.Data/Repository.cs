using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace MusicTheory.Data
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private bool _disposed = false;

        // ReSharper disable once MemberCanBeProtected.Global
        public IDbContext Context { get; private set; }

        protected Repository(IDbContext context)
        {
            Context = context;
        }

        public IQueryable<T> GetAll()
        {
            IQueryable<T> query = Context.Set<T>();
            return query;
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = Context.Set<T>().Where(predicate);
            return query;
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
        }

        public void Edit(T entity)
        {
            SetEntryModified(entity);
        }

        public virtual void SetEntryModified(T entity)
        {
            Context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }
    }
}

