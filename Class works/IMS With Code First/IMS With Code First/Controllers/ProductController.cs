using IMS_With_Code_First.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IMS_With_Code_First.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            InventoryDbContext dbContext = new InventoryDbContext();
            var list = dbContext.Products.ToList();
            return View();
        }
    }
}