using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;
using DailyLog.Core.Domain;

namespace DailyLog.Web.Helpers
{
    public class NHibernateBootstrapper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory sessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    InitializeSessionFactory();

                return _sessionFactory;
            }
        }

        private static void InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(@"Server=SERENITY;Database=DailyLog;Trusted_Connection=True;").ShowSql())
                .Mappings(m => m.FluentMappings
                                .AddFromAssemblyOf<User>())
                                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(false, false))
                                .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return sessionFactory.OpenSession();
        }
    }
}