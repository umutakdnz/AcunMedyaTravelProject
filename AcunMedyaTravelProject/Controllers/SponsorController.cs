﻿using AcunMedyaTravelProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaTravelProject.Controllers
{
    public class SponsorController : Controller
    {
        // GET: Sponsor

        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();
        public ActionResult Index()
        {
            var values = _context.Sponsors.ToList();
            return View(values);
        }

        public ActionResult DeleteSponsor(int id)
        {
            var value = _context.Sponsors.Find(id);
            _context.Sponsors.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddSponsor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSponsor(Sponsor model)
        {
            _context.Sponsors.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSponsor(int id)
        {
            var value = _context.Sponsors.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateSponsor(Sponsor model)
        {
            var value = _context.Sponsors.Find(model.SponsorID);
            value.ImageUrl = model.ImageUrl;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}