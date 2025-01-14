using AcunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class SocialMediaController : Controller
    {
        // GET: SocialMedia
        PortfolioDbEntities1 db = new PortfolioDbEntities1();

        public ActionResult Index()
        {
            var value = db.SocialMedia.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult CreateSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSocialMedia(SocialMedia sm)
        {
            db.SocialMedia.Add(sm);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult DeleteSocialMedia(int id)
        {
            var value = db.SocialMedia.Find(id);
            db.SocialMedia.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSocialMedia(int id)
        {
            var value=db.SocialMedia.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSocialMedia(SocialMedia sm)
        {
            var value = db.SocialMedia.Find(sm.Id);
            value.Name= sm.Name;
            value.Icon= sm.Icon;
            value.Url= sm.Url;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}