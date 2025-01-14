using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolioProject.Models;
namespace AcunMedyaPortfolioProject.Controllers
{
    public class IntroductıonsController : Controller
    {
        // GET: Introductıons
        PortfolioDbEntities1 db=new PortfolioDbEntities1();
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
        public ActionResult CreateIntroduction(Introductions ınt)
        {
            db.Introductions.Add(ınt);
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
        public ActionResult UpdateIntroduction(Introductions ınt)
        {
            var value = db.Introductions.Find(ınt.Id);
            value.Title = ınt.Title;
            value.Description=ınt.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}