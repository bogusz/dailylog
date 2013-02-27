using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using DailyLog.Core.Abstract;
using DailyLog.Core.Domain;
using DailyLog.Web.Helpers;
using DailyLog.Web.Models;
using NHibernate;
using NHibernate.Linq;
using DailyLog.Core.Infrastructure;

namespace DailyLog.Web.Controllers
{
    public partial class EntryController : Controller
    {        
        private readonly IUserRepository userRepository;
        private readonly IEntryRepository entryRepository;

        protected User CurrentUser { get; set; }

        public EntryController(IEntryRepository entryRepository, IUserRepository userRepository)
        {
            this.userRepository = userRepository;
            this.entryRepository = entryRepository;

            CurrentUser = userRepository.Query().FirstOrDefault();
        }

        public virtual ActionResult List()
        {
            var entries = entryRepository.GetAll();

            return View(entries);
        }

        public virtual ActionResult Add()
        {            
            return View(new AddEntryViewModel());
        }

        [HttpPost]
        public virtual ActionResult Add(AddEntryViewModel model)
        {
            using (var unitOfWork = UnitOfWork.Begin())
            {
                var entry = new Entry();
                entry.Content = model.Content;
                entry.ForDate = DateTime.Now;
                entry.User = CurrentUser;
                entryRepository.Save(entry);

                unitOfWork.Commit();
            }            

            return RedirectToAction(MVC.Entry.List());
        }        
    }
}
