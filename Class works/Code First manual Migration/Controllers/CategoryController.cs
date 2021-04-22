using Code_First_manual_Migration;
using Code_First_manual_Migration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Code_First_manual_Migration.Controllers
{
    public class CategoryController : Controller
    {
        
        public ActionResult Index()
        {
            InventoryDbContext dbContext = new InventoryDbContext();
            var list = dbContext.Categories.ToList();
            return View(list);
        }
    }
}