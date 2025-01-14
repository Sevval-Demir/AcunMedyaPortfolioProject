using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolioProject.Models;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class EducationsController : Controller
    {
        // GET: Educations
        PortfolioDbEntities1 db=new PortfolioDbEntities1();
        public ActionResult Index()
        {
            var value = db.Educations.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult CreateEducation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateEducation(Educations ed)
        {
            db.Educations.Add(ed);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteEducation(int id)
        {
            var value=db.Educations.Find(id);
            db.Educations.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var value= db.Educations.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateEducation(Educations ed)
        {
            var value = db.Educations.Find(ed.Id);
            value.Title = ed.Title;
            value.InstutionName = ed.InstutionName;
            value.StartDate = ed.StartDate;
            value.EndDate = ed.EndDate;
            value.Description= ed.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}