using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logging_System.Models;
using Logging_System.EFramework;
using System.Web.Security;

namespace Logging_System.Controllers
{
   
    public class LearnerController : Controller
    {
        //
        // GET: /Learner/
        
        public ActionResult Login()
        {
            return View();

        }

        public ActionResult DoLogin(string txtUsername, string txtPassword)
        {
            Dal odal = new Dal();
            LearnerLogin learnerlogin = new LearnerLogin();

            learnerlogin = (
                from frm in odal.learners.ToList()
                where frm.Username == txtUsername && frm.Password == txtPassword && frm.IsActive == true
                select frm).Single();

            if (learnerlogin != null)
            {
                Session["Username"] = learnerlogin.Username;
                FormsAuthentication.SetAuthCookie(learnerlogin.Username, false);
                return RedirectToAction("Complete", "Complete");

            }
            else
            {
                return View("Login");
            }

        }
        public ActionResult Logout()
        {

            FormsAuthentication.SignOut();
            return View("Login");
        }


    }
}