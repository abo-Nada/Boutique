using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Boutique.BusinessLogic.Repository
{
    public class Repository<TEnity, TContext> : IRepository<TEnity>
        where TEnity : class
        where TContext : DbContext, new()
    {
        TContext context;
        DbSet<TEnity> set;
        public Repository(TContext _context)
        {
            context = _context;
            set = context.Set<TEnity>();
        }
        public TEnity Add(TEnity entity)
        {
            set.Add(entity);
            return context.SaveChanges() > 0 ? entity : null;
        }

        public IQueryable<TEnity> GetAll()
        {
            return set;
        }

        public TEnity GetById(params object[] id)
        {
            return set.Find(id);
        }

        public bool Remove(params object[] id)
        {
            var entity = set.Find(id);
            set.Remove(entity);
            return context.SaveChanges() > 0;
        }

        public bool Update(TEnity entity)
        {
            set.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            return context.SaveChanges() > 0;
        }
    }
}