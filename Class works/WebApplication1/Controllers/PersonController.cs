using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            List<Person> allPerson = new List<Person>();
            allPerson.Add(new Person() { Name = "Md. Sirajuddin", Id = "18-36449-1", Hobby = "Playing Video Games" });
            allPerson.Add(new Person() { Name = "Eraj", Id = "18-36421-1", Hobby = "Playing Video Games" });

            return View(allPerson);
        }
    }
}