using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace DailyLog.Web
{    
    public class User
    {
        public virtual int UserId { get; set; }

        public virtual string Email { get; set; }

        public virtual string Name { get; set; }
    }

    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("Users");
            Id(x => x.UserId);
            Map(x => x.Email);
        }
    }
}