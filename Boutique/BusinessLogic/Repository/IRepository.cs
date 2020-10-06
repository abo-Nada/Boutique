using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Boutique.BusinessLogic.Repository
{
    public interface IRepository<TEntity>
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(params object[] id);
        TEntity Add(TEntity entity);
        bool Update(TEntity entity);
        bool Remove(params object[] id);
    }
}