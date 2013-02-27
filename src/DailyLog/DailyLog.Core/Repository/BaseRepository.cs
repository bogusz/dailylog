using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DailyLog.Core.Abstract;
using DailyLog.Core.Domain;
using NHibernate;
using NHibernate.Linq;

namespace DailyLog.Core.Repository
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity>
    {
        protected readonly ISession session;

        public BaseRepository(ISession session)
        {
            this.session = session;
        }

        public void Save(TEntity entity)
        {
            session.Save(entity);
        }

        public IQueryable<TEntity> Query()
        {
            return session.Query<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Query().ToList();
        }
    }
}
