using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolioProject.Models;
namespace AcunMedyaPortfolioProject.Controllers
{
    public class IntroductionsController : Controller
    {
        // GET: Introductions
        PortfolioDbEntities1 db = new PortfolioDbEntities1();
        public ActionResult Index()
        {
            var value = db.Introductions.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult CreateIntroduction()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateIntroduction(Introductions value)
        {
                db.Introductions.Add(value);
                db.SaveChanges();
                return RedirectToAction("Index");
        }
        public ActionResult DeleteIntroduction(int id)
        {
                var value = db.Introductions.Find(id);
                db.Introductions.Remove(value);
                db.SaveChanges();
                return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateIntroduction(int id)
        {
            var value = db.Introductions.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateIntroduction(Introductions i)
        {
            var value = db.Introductions.Find(i.Id);
                value.Title =i.Title;
                value.Description = i.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}