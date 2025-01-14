using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolioProject.Models;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class ExperiencesController : Controller
    {
        // GET: Experiences
        PortfolioDbEntities1 db=new PortfolioDbEntities1();
        public ActionResult Index()
        {
            var value = db.Experiences.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult CreateExperiences()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateExperiences(Experiences exp)
        {
            db.Experiences.Add(exp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteExperiences(int id)
        {
            var value = db.Experiences.Find(id);
            db.Experiences.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateExperiences(int id)
        {
            var value = db.Experiences.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateExperiences(Experiences exp)
        {
            var value = db.Experiences.Find(exp.Id);
            value.Title = exp.Title;
            value.CompanyName = exp.CompanyName;
            value.StartDate = exp.StartDate;
            value.EndDate = exp.EndDate;
            value.Description = exp.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}