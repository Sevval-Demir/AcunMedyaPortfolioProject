using AcunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        PortfolioDbEntities1 db = new PortfolioDbEntities1();
            
        public ActionResult Index()
        {
             var aboutList = db.About.ToList();
             return View(aboutList); 
        }

        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAbout(About about)  
        {
            db.About.Add(about);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteAbout(int id)
        {
            var value = db.About.Find(id);
           db.About.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var about = db.About.Find(id);
            return View(about);
        }

        [HttpPost]
        public ActionResult UpdateAbout(About about)
        {
            var updateAbout = db.About.Find(about.Id);
            updateAbout.Description = about.Description;
            updateAbout.CVLink = about.CVLink;
            updateAbout.Title = about.Title;
            updateAbout.ImageUrl = about.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        }
    }