using AcunMedyaTravelProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaTravelProject.Controllers
{
    public class DestinationsController : Controller
    {
        // GET: Destinations

        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();
        public ActionResult Index()
        {
            var values = _context.Destinations.ToList();
            return View(values);
        }

        public ActionResult DeleteDestinations(int id)
        {
            var value = _context.Destinations.Find(id);
            _context.Destinations.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddDestinations()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDestinations(Destinations model)
        {
            _context.Destinations.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateDestinations(int id)
        {
            var value = _context.Destinations.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateDestinations(Destinations model)
        {
            var value = _context.Destinations.Find(model.DestinationsID);
            value.ImageUrl = model.ImageUrl;
            value.Title = model.Title;
            value.Description1 = model.Description1;
            value.Description2 = model.Description2;
            value.CategoryID = model.CategoryID;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}