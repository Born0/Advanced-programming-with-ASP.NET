using IMS_EF6_DB_First.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IMS_EF6_DB_First.Controllers
{
    public class ProductController : Controller
    {
        InventoryDBEntities context = new InventoryDBEntities();
        public ActionResult Index()
        {
            return View(context.Products.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var productToEdit = context.Products.Find(id);
            return View(productToEdit);
        }

        [HttpPost]
        public ActionResult Edit(int id, Product product)
        {
            product.ProductId = id;
            context.Entry(product).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult Delete (int id)
        {
            var productToEdit = context.Products.Find(id);
            return View(productToEdit);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult ConfirmDelete(int id)
        {
            context.Products.Remove(context.Products.Find(id));
            context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}