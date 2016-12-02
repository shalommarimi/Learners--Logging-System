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
using System.Net.Mail;

namespace Logging_System.Controllers
{

    public class MentorController : Controller
    {
        // GET: Mentor

        public ActionResult Login()
        {
            return View();
        }


        [Authorize]
        public ActionResult Register()
        {

           return View();
        }

        [Authorize]
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
            ViewBag.Error = "Username or Password is incorret";

            try
            {
              mentorlogin = (
              from frm in dal.mentors.ToList()
              where frm.Username == txtUsername && frm.Password == txtPassword && frm.IsActive == true
              select frm).Single();
            }
            catch (Exception)
            {

                ViewBag.Error = "Username or Password is incorrect.";
                return View("Login");
            }

          

            if (mentorlogin != null)
            {
                Session["FirstName"] = mentorlogin.FirstName.ToString();
                Session["Surname"] = mentorlogin.Surname.ToString();
                //Session["Role"] = mentorlogin.Role.ToString();

                FormsAuthentication.SetAuthCookie(mentorlogin.Username, false);
                return RedirectToAction("Sign", "Sign");

            }
            else
            {
                return View("Login");
            }

        }
        [Authorize]
        public ActionResult Logout()
        {

            FormsAuthentication.SignOut();
            return View("Login");
        }

      
    }
}