using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using StructureMap;

namespace DailyLog.Core.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly ISession session;
        protected readonly ITransaction transaction;

        public UnitOfWork(ISession session)
        {
            this.session = session;
            transaction = session.BeginTransaction();
        }

        public void Dispose()
        {
            if (transaction != null)
                transaction.Dispose();
        }

        public void Commit()
        {
            if (transaction.IsActive)
                transaction.Commit();
        }

        public void Rollback()
        {
            if (transaction.IsActive)
                transaction.Rollback();
        }

        public static IUnitOfWork Begin()
        {
            return ObjectFactory.GetInstance<IUnitOfWork>();
        }
    }
}
