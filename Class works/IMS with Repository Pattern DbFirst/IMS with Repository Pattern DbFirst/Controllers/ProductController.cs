using IMS_with_Repository_Pattern_DbFirst.Models;
using IMS_with_Repository_Pattern_DbFirst.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IMS_with_Repository_Pattern_DbFirst.Controllers
{
    public class ProductController : Controller
    {
        ProductRepository productRepository = new ProductRepository();
        public ActionResult Index()
        {
            return View(productRepository.GetAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create( Product  product)
        {
            productRepository.Insert(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var toEdit = productRepository.Get(id);
            return View(toEdit);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            productRepository.Update(product);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var toDelete = productRepository.Get(id);
            return View(toDelete);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult ConfirmDelete(int id)
        {
            productRepository.Delete(id);
            return RedirectToAction("Index");
        }

    }
}