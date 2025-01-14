using AcunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        PortfolioDbEntities1 db = new PortfolioDbEntities1();

        public ActionResult Index()
        {
            var value = db.Contact.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatContact(Contact contact)
        {
            db.Contact.Add(contact);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteContact(int id)
        {
            var value = db.Contact.Find(id);
            db.Contact.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateContact(int id)
        {
            var value = db.Contact.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateContact(Contact contact)
        {
            var value = db.Contact.Find(contact.Id);
            value.Phone = contact.Phone;
            value.MailAddress = contact.MailAddress;
            value.Address = contact.Address;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}