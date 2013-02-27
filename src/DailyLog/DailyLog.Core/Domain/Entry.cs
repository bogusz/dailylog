using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace DailyLog.Core.Domain
{    
    public class Entry
    {
        public virtual int EntryId { get; set; }

        public virtual string Content { get; set; }

        public virtual DateTime ForDate { get; set; }

        public virtual User User { get; set; }
    }

    public class EntryMap : ClassMap<Entry>
    {
        public EntryMap()
        {
            Table("Entries");
            Id(x => x.EntryId);
            Map(x => x.Content);
            Map(x => x.ForDate);
            References(x => x.User, "UserId");
        }
    }
}