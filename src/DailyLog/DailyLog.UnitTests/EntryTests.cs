using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using DailyLog.Core;
using DailyLog.Web.Controllers;
using Moq;
using NUnit.Framework;
using Should;

namespace DailyLog.UnitTests
{
    [TestFixture]
    public class EntryTests
    {
        [Test]
        public void index_returns_message()
        {
            //var entryRepository = new Mock<IEntryRepository>();
            //entryRepository.Setup(m => m.SayHello()).Returns("hello world");

            //var controller = new EntryController(entryRepository.Object);

            //var result = (ContentResult)controller.Index();

            //result.Content.ShouldEqual("hello world");
        }

    }
}
