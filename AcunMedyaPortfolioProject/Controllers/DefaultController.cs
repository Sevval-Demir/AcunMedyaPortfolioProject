using AcunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class DefaultController : Controller
    {
        PortfolioDbEntities1 db = new PortfolioDbEntities1();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            ViewBag.Title = "Portfolio - Acun Medya";
            return PartialView();
        }

        public PartialViewResult PartialSiteHeader()
        {
            return PartialView();
        }

        public PartialViewResult PartialIntro()
        {
            var intro = db.Introductions.FirstOrDefault();
            return PartialView(intro);
        }

        public PartialViewResult PartialAbout()
        {
            var about = db.About.FirstOrDefault();
            return PartialView(about);
        }

        public PartialViewResult PartialExperience()
        {
            var experiences = db.Experiences.ToList();
            return PartialView(experiences);
        }

        public PartialViewResult PartialEducation()
        {
            var education = db.Educations.ToList();
            return PartialView(education);
        }

        public PartialViewResult PartialProject()
        {
            var projects = db.Projects.ToList();
            return PartialView(projects);
        }

        public PartialViewResult PartialTestimonial()
        {
            var testimonials = db.Testimonials.ToList();
            return PartialView(testimonials);
        }

        public PartialViewResult PartialContact()
        {
            var contact= db.Contact.FirstOrDefault();
            return PartialView(contact);
        }


        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }

        public PartialViewResult PartialSocialMedia()
        {
            var socialMedia = db.SocialMedia.ToList();
            return PartialView();
        }

        public PartialViewResult PartialExpertise()
        {
            var expertise = db.Expertise.FirstOrDefault();
            return PartialView(expertise);
        }

        public PartialViewResult PartialFooter()
        {
            var value = db.Categories.ToList();
            ViewBag.Categories= value;
            return PartialView();
        }

    }
}