using IMS_with_Repository_Pattern_DbFirst.Models;
using IMS_with_Repository_Pattern_DbFirst.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IMS_with_Repository_Pattern_DbFirst.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();
        public ActionResult Index()
        {
            return View(categoryRepository.GetAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            categoryRepository.Insert(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var toEdit= categoryRepository.Get(id);
            return View(toEdit);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            categoryRepository.Update(category);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var toDelete = categoryRepository.Get(id);
            return View(toDelete);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult ConfirmDelete(int id)
        {
            categoryRepository.Delete(id);
            return RedirectToAction("Index");
        }


    }
}