using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MusicTheory.Data
{
    public abstract class ReadOnlyRepository<T> : IReadOnlyRepository<T> where T : class
    {
        private bool _disposed = false;

        // ReSharper disable once MemberCanBeProtected.Global
        public IDbContext Context { get; private set; }

        protected ReadOnlyRepository(IDbContext context)
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

    }
}
