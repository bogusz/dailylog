using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DailyLog.Core.Domain;
using NHibernate;
using NHibernate.Linq;
using DailyLog.Core.Abstract;

namespace DailyLog.Core.Abstract
{
    public interface IUserRepository : IRepository<User>
    {             
    }
}
