using Code_First_manual_Migration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Code_First_manual_Migration.Controllers
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