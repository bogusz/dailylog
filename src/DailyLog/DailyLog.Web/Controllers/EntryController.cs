using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using DailyLog.Web.Helpers;

namespace DailyLog.Web.Controllers
{
    public class EntryController : Controller
    {        
        public ActionResult Index()
        {
            StringBuilder sb = new StringBuilder();

            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var users = session.QueryOver<User>().List();

                    foreach (var user in users)
                    {
                        sb.Append(user.Email + "<br/>");
                    }

                    transaction.Commit();
                }
            }


            ViewBag.Message = sb.ToString();

            return View();
        }
    }
}
