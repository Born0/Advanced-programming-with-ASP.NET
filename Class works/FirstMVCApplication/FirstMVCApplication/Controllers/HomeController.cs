using FirstMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApplication.Controllers
{
    
    public class HomeController : Controller
    {
        

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        
        public ActionResult Index(Person person/*, HttpPostedFileBase file*/)
        {
            if (person.Name ==null)
            {
                ViewData["msg"] = "Please give your name";
                return View();
            }

            if (person.UserName == null)
            {
                ViewData["msg"] = "Please give your USer name";
                return View();
            }
            if (person.Password == null)
            {
                ViewData["msg"] = "Please give your Password";
                return View();
            }
            if (person.ConfirmPassword == null)
            {
                ViewData["msg"] = "Please give your ConfirmPassword";
                return View();
            }
            if(person.Password!=person.ConfirmPassword)
            {
                ViewData["msg"] = "password and confirm password did not match";
                return View();
            }
            if (person.DateOfBirth == null)
            {
                ViewData["msg"] = "Please give your DateOfBirth";
                return View();
            }
            if (person.BloodGroup == null)
            {
                ViewData["msg"] = "Please give your BloodGroup";
                return View();
            }
            if (person.Gender == null)
            {
                ViewData["msg"] = "Please give your Gender";
                return View();
            }
            try
            {
                if (person.ProfilePicture.ContentLength > 0)
                {
                    string _FileName = Path.GetFileName(person.ProfilePicture.FileName);
                    string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);
                    person.ProfilePicture.SaveAs(_path);
                }
                ViewData["msg"] = "File Uploaded Successfully!!";
            }
            catch
            {
                ViewData["msg"] = "File upload failed!!";
                return View();
            }

            string imgName = Path.GetFileName(person.ProfilePicture.FileName);
            

            string details = person.Name + "<br>" + person.UserName + "<br>" + person.Password + "<br>" + person.DateOfBirth + "<br>" +
                person.BloodGroup + "<br>" + person.Gender + "<br>";
            return Content(details + "< img src =" + imgName + " >  ");
            //return RedirectToAction(p)
            
        }
    }
}