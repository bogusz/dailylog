using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyLog.Core.Abstract
{
    public interface IRepository<TEntity>
    {        
        IQueryable<TEntity> Query();

        void Save(TEntity entity);

        IEnumerable<TEntity> GetAll();
    }
}
