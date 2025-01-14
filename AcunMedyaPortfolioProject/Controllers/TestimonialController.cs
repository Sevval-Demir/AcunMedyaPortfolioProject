using AcunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        PortfolioDbEntities1 db = new PortfolioDbEntities1();
        public ActionResult Index()
        {
            var testimonialsList = db.Testimonials.ToList();
            return View(testimonialsList);
        }

        [HttpGet]
        public ActionResult CreateTestimonials()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatTestimonials(Testimonials testimonials)
        {
            db.Testimonials.Add(testimonials);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteTestimonials(int id)
        {
            var value = db.Testimonials.Find(id);
            db.Testimonials.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateTestimonials(int id)
        {
            var testimonials = db.Testimonials.Find(id);
            return View(testimonials);
        }

        [HttpPost]
        public ActionResult UpdateTestimonials(Testimonials testimonials)
        {
            var updateTestimonials = db.Testimonials.Find(testimonials.Id);
            updateTestimonials.NameSurname = testimonials.NameSurname;
            updateTestimonials.Title = testimonials.Title;
            updateTestimonials.ImageUrl = testimonials.ImageUrl;
            updateTestimonials.Comment=testimonials.Comment;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}