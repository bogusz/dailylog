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
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ISession session) : base(session)
        {
        }

        //using (var session = NHibernateHelper.OpenSession())
        //{
        //    using (var transaction = session.BeginTransaction())
        //    {
        //        var users = session.Query<User>().ToList();

        //        foreach (var user in users)
        //        {
        //            sb.Append(user.Email + "<br/>");
        //        }

        //        transaction.Commit();                    
        //    }
        //}
    }
}
