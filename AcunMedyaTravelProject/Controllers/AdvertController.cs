using AcunMedyaTravelProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaTravelProject.Controllers
{
    public class AdvertController : Controller
    {
        // GET: Booking2

        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();
        public ActionResult Index()
        {
            var values = _context.Bookings2.ToList();
            return View(values);
        }

        public ActionResult DeleteAdvert(int id)
        {
            var value = _context.Bookings2.Find(id);
            _context.Bookings2.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddAdvert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAdvert(Booking2 model)
        {
            _context.Bookings2.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateAdvert(int id)
        {
            var value = _context.Bookings.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateAdvert(Booking2 model)
        {
            var value = _context.Bookings2.Find(model.Booking2ID);
            value.Title = model.Title;
            value.Date = model.Date;
            value.Description = model.Description;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}