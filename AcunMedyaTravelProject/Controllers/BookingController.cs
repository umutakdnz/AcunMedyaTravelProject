using AcunMedyaTravelProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaTravelProject.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking

        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();
        public ActionResult Index()
        {
            var values = _context.Bookings.ToList();
            return View(values);
        }

        public ActionResult DeleteBooking(int id)
        {
            var value = _context.Bookings.Find(id);
            _context.Bookings.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddBooking()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBooking(Booking model)
        {
            _context.Bookings.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateBooking(int id)
        {
            var value = _context.Bookings.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateBooking(Booking model)
        {
            var value = _context.Bookings.Find(model.BookingID);
            value.Title = model.Title;
            value.Description = model.Description;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}