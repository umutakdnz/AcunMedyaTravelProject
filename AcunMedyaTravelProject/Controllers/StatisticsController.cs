using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaTravelProject.Entities;

namespace AcunMedyaTravelProject.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Statistics

        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();
        public ActionResult Index()
        {
            ViewBag.AdminCount = _context.Admins.Count();
            ViewBag.ServicesCount = _context.Services.Count();
            ViewBag.TestimonialCount = _context.Testimonials.Count();
            ViewBag.DestinationCount = _context.Destinations.Count();
            ViewBag.CategoryCount = _context.Categories.Count();

            ViewBag.LastTestimonial = _context.Testimonials.OrderByDescending(t => t.TestimonialID).Select(t => t.Name).FirstOrDefault();
            ViewBag.LastDestinations = _context.Destinations.OrderByDescending(d => d.DestinationsID).Select(d => d.Title).Take(3).ToList();
            ViewBag.FirstDestinations = _context.Destinations.OrderBy(d => d.DestinationsID).Select(d => d.Title).Take(3).ToList();
            ViewBag.LastCategory = _context.Categories.OrderByDescending(t => t.CategoryID).Select(t => t.CategoryName).FirstOrDefault();
            ViewBag.LastServices = _context.Services.OrderByDescending(t => t.ServicesID).Select(t => t.Title).FirstOrDefault();
            return View();
        }
    }
}