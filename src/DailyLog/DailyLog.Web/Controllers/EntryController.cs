using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DailyLog.Web.Controllers
{
    public class EntryController : Controller
    {        
        public ActionResult Index()
        {
            ViewBag.Message = "Hello World!";

            return View();
        }
    }
}
