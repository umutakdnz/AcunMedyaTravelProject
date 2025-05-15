using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using AcunMedyaTravelProject.Entities;

namespace AcunMedyaTravelProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default PartialView

        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

        public PartialViewResult PartialSlider()
        {
            var values = _context.Sliders.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialService()
        {
            var values = _context.Services.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialDestinations()
        {
            var values = _context.Destinations.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialBooking()
        {
            var values = _context.Bookings.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialBooking2()
        {
            var values = _context.Bookings2.ToList();
            return PartialView(values);
        } 

        public PartialViewResult PartialTestimonial()
        {
            var values = _context.Testimonials.ToList();
            return PartialView(values); 
        }

        public PartialViewResult PartialSponsor()
        {
            var values = _context.Sponsors.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialCopyright()
        {
            return PartialView();
        }

        public PartialViewResult PartialContact()
        {
            return PartialView();
        }

        [HttpPost]
        public JsonResult PartialContact(Mail model)
        {
            if (ModelState.IsValid)
            {
                _context.Mails.Add(model);
                _context.SaveChanges();
                return Json(new { success = true, message = "Tebrikler Abone Oldunuz" });
            }
            else
            {
                return Json(new { success = false, message = " Hata! Abone Olamadınız" });
            }
        }
    }
}