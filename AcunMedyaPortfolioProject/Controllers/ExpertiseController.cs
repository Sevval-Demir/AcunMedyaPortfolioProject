using AcunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class ExpertiseController : Controller
    {
        // GET: Expertise
        PortfolioDbEntities1 db=new PortfolioDbEntities1();

        public ActionResult Index()
        {
            var value = db.Expertise.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult CreateExpertise()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateExpertise(Expertise exp)
        {
            db.Expertise.Add(exp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteExpertise(int id)
        {
            var value = db.Expertise.Find(id);
            db.Expertise.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateExpertise(int id)
        {
            var value = db.Expertise.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateExpertise(Expertise exp)
        {
            var value = db.Expertise.Find(exp.Id);
            value.Name = exp.Name;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}