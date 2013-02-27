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
    public class EntryRepository : BaseRepository<Entry>, IEntryRepository
    {
        public EntryRepository(ISession session)
            : base(session)
        {
        }        
    }
}
