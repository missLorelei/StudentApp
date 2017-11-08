using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentAppAdo.Models;
using System.Data.Entity;

namespace StudentAppAdo.Controllers
{
    public class CityController : Controller
    {
        DbModel db = new DbModel();
        // GET: City
        [HttpGet]
        public ActionResult List()
        {
            ViewBag.Cities = City.Find();
            return View();
        }

        public ActionResult ActionFind()
        {
            var ResultT = City.Find();

            return Json(ResultT);
        }
        // Add City
        [HttpGet]
        public ActionResult CreateCity()
        {
            return View();           
        }

        [HttpPost]
        public ActionResult CreateCity (City city)
        {
            db.Cities.Add(city);
           // db.Entry(city).State = EntityState.Added;
            if (db.SaveChanges() > 0)
            {
                return RedirectToAction("List");               
            }
            else
            {
                return HttpNotFound();
            }

        }
        // Edit City
        [HttpGet]
        public ActionResult EditCity(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            
            City city = db.Cities.Find(id);
           
                if (city != null)
            {
                return View(city);
            }
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult EditCity(City city)
        {
            db.Entry(city).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("List");
        }

        // delete City
        [HttpPost]
        public ActionResult List(int id)
        {
            City c = db.Cities.Find(id);
            if (c == null)
            {
                return HttpNotFound();
            }
            db.Cities.Remove(c);
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}