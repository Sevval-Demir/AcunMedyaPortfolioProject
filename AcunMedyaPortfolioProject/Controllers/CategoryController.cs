using AcunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        PortfolioDbEntities1 db = new PortfolioDbEntities1();

        public object[] CategoryID { get; private set; }
        public string CategoryName { get; private set; }

        public ActionResult CategoryList()
        {
            var categoryList = db.Categories.ToList();
            return View(categoryList);
        }

        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(Categories categories)
        {
            db.Categories.Add(categories);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }

        public ActionResult DeleteCategory(int id)
        {
            var categories = db.Categories.Find(id);
            db.Categories.Remove(categories);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var categories = db.Categories.Find(id);
            return View(categories);
        }

        [HttpPost]
        public ActionResult UpdateCategory(Categories categories)
        {
            var updatedCategory = db.Categories.Find(categories.CategoryID);
            updatedCategory.CategoryName = categories.CategoryName;
            db.SaveChanges();
            return RedirectToAction("CategoryList");

        }


    }
}