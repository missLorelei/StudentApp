using StudApp.Context;
using StudApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (StudentContext db = new StudentContext())
            {
                Student st1 = new Student();
                db.Students.Add(st1);
                db.SaveChanges();
            }
                return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}