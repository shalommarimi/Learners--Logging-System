using Logging_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Logging_System.Controllers
{
    public class LogbookController : Controller
    {
        // GET: Logbook
        [Authorize]
        public ActionResult SignLogBook(Logbook logbooks)
        {
            if (ModelState.IsValid)
            {
                Logbook log = new Logbook();
                string results = log.CreateLogbook(logbooks);
                ViewData["result"] = results;
                ModelState.Clear();
                return View();
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Please ensure that all required fieds are filled");
                return View();
            }
        }
        public ActionResult Logout()
        {

            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Learner");
        }

    }
}