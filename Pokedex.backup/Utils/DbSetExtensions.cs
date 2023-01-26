using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Utils
{
    public static class DbSetExtensions
    {
        public static T AddIfNotExists<T>(this DbSet<T> dbSet, T entity, Expression<Func<T, bool>> predicate = null) where T : class, new()
        {
            var exists = predicate != null ? dbSet.Any(predicate) : dbSet.Any();
            if (exists)
            {
                return null;
            }
            dbSet.Add(entity);
            return entity;
        }
        public static T Upsert<T>(this DbSet<T> dbSet, T entity, Expression<Func<T, bool>> predicate = null) where T : class, new()
        {
            var exists = predicate != null ? dbSet.Any(predicate) : dbSet.Any();

            if (exists)
            {
                dbSet.Attach(entity);
            }
            else
            {
                dbSet.Add(entity);
            }
            return entity;
        }
    }
}
