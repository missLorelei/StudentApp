using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentAppAdo.Models;
using System.Data.Entity;

namespace StudentAppAdo.Controllers
{
    public class SubjectController : Controller
    {
        DbModel db = new DbModel();
        // GET: Subject
        [HttpGet]
        public ActionResult List()
        {
            ViewBag.Subjects = Subject.Find();
            return View();
        }

        // create Subject 
        [HttpGet]
        public ActionResult CreateSubject()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult CreateSubject(Subject subject)
        {
            if (subject != null)
            {
                db.Subjects.Add(subject);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                return HttpNotFound();
            }
        }
        // Edit List
        [HttpGet]
        public ActionResult EditSubject(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Subject subject = db.Subjects.Find(id);

            if (subject != null)
            {
                return View(subject);
            }
            else
            {
                return HttpNotFound();
            }
        }

        [HttpPost]
        public ActionResult EditSubject(Subject subject)
        {
            if (subject != null)
            {
                db.Entry(subject).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                return HttpNotFound();
            }
        }

        // delete Subject
        [HttpPost]
        public ActionResult List(int? id)
        {
            Subject s = db.Subjects.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            db.Subjects.Remove(s);
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}