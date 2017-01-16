using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Logging_System.Controllers
{
    public class MonthlyEvaluationFormController : Controller
    {
        // GET: MonthlyEvaluationForm
        [Authorize]
        public ActionResult CompleteMonthlyEvaluationForm()
        {
            return View();
        }
        public ActionResult Logout()
        {

            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Learner");
        }
    }
}