using Logging_System.EFramework;
using Logging_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebMatrix.Data;
using Learn.BL;


namespace Logging_System.Controllers
{

    public class MentorController : Controller
    {
        // GET: Mentor

        public ActionResult Login()
        {
            return View();
        }


        public ActionResult Register()
        {


            return View();
        }

        [HttpPost]
        public ActionResult Register(Learners _learners)
        {
            if (ModelState.IsValid)
            {
                Learners _lear = new Learners();
                string result = _lear.InsertRegDetails(_learners);
                ViewData["result"] = result;
                ModelState.Clear();
                return View();
            }
            else
            {
                ModelState.AddModelError(string .Empty,"Could Not Register Learner");
                return View();
            }
           
        }
      

        public ActionResult DoLogin(string txtUsername, string txtPassword)
        {
            Dal dal = new Dal();
            MentorLogin mentorlogin = new MentorLogin();

            mentorlogin = (
                from frm in dal.mentors.ToList()
                where frm.Username == txtUsername && frm.Password == txtPassword && frm.IsActive == true
                select frm).Single();

            if (mentorlogin != null)
            {
                Session["Username"] = mentorlogin.Username;
                FormsAuthentication.SetAuthCookie(mentorlogin.Username, false);
                return RedirectToAction("Sign", "Sign");

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