using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Logging_System.Controllers
{
    public class SignController : Controller
    {
        // GET: Sign
        [Authorize]
        public ActionResult Sign()
        {
            return View();
        }

        public ActionResult Logout()
        {

            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Mentor");
        }
    }
}