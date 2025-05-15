using AcunMedyaTravelProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaTravelProject.Controllers
{
    public class MailController : Controller
    {
        // GET: Mail
        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();
        public ActionResult Index()
        {
            var values = _context.Mails.ToList();
            return View(values);
        }

        public ActionResult DeleteMail(int id)
        {
            var value = _context.Mails.Find(id);
            _context.Mails.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult SearchMail(string searchText)
        {
            var result = string.IsNullOrEmpty(searchText) ? new List<Mail>() : _context.Mails.Where(x => x.MailName.Contains(searchText)).ToList();
            return View(result);
        }
    }
}