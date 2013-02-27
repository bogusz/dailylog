using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DailyLog.Core.Domain;
using NHibernate;
using NHibernate.Linq;

namespace DailyLog.Core.Abstract
{
    public interface IEntryRepository : IRepository<Entry>
    {        
    }
}
