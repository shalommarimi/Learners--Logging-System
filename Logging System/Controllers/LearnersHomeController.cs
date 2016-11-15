using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Logging_System.Controllers
{
    public class LearnersHomeController : Controller
    {
        // GET: LearnersHome
        public ActionResult Learner_Home()
        {
            return View();
        }



        private bool isValidContentType(string contentType)
        {
            return contentType.Equals("application/pdf") || contentType.Equals("application/vnd.openxmlformats-officedocument.wordprocessingml.document") || contentType.Equals("application/msword");
        }

        private bool isValidSizeLength(int contentLength)
        {
            return ((contentLength / 1024) / 1024) < 1; //1MB
        }

        [HttpPost]
        public ActionResult Process(HttpPostedFileBase photo)
        {
            if (!isValidContentType(photo.ContentType))
            {
                ViewBag.Error = "Only PDF & DOCX files are accepted.";
                return View("Learner_Home");
            }
            else if (!isValidSizeLength(photo.ContentLength))
            {
                ViewBag.Error = "File Size Limit, Document should be less than 2MB";
                return View("Learner_Home");
            }
            else
            {
                if (photo.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(photo.FileName);
                    var path = Path.Combine(Server.MapPath("~/ProofOfAbsence"), fileName);
                    photo.SaveAs(path);
                    ViewBag.fileName = photo.FileName;
                }
            }

            ViewBag.fileName = photo.FileName;
            return View("Success");

        }
    







    [HttpPost]
        public ViewResult Learner_Home(Logging_System.Models.Email _objModelMail)
        {
            

            if (ModelState.IsValid)
            {

                MailMessage mail = new MailMessage();
                mail.To.Add(_objModelMail.Sendto);
                mail.From = new MailAddress(_objModelMail.SentFrom);
                mail.Subject = _objModelMail.Subject;
                string Body = _objModelMail.Message;
                mail.Body = Body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                //smtp.Port = 465;
                //smtp.Port = 2525;

                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential
                ("learnerslogsystem@gmail.com", "Jedia.01");// Enter seders User name and password
                smtp.EnableSsl = true;
                smtp.Send(mail);
                return View("Index", _objModelMail);
            }
            else
            {
                return View();
            }
        }
    }
}