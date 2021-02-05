using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        /*public ActionResult Index(int? id)
        {
            return RedirectToAction("Another", new { id = 50 });
        }
        public ActionResult Another(int? id)
        {
            return Content("from another :" + id);
            //return RedirectToAction("Index", "Person");
        }*/

        public ActionResult Index()
        {
            //Session["name"] = "sakib";
            //ViewData["name"] = "tamim";
            //ViewBag.name = "musfique";
            
            return RedirectToAction("Another");
        }
        public ActionResult Another()
        {
            return View();
            
        }


    }
}