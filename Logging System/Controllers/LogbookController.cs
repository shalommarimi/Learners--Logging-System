using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Logging_System.Controllers
{
    public class LogbookController : Controller
    {
        // GET: Logbook
        [Authorize]
        public ActionResult SignLogBook()
        {
            return View();
        }
    }
}