using MySiteMVC4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace MySiteMVC4.Controllers
{
    public class HomeController : Controller
    {

        ReviewContext db = new ReviewContext();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Karp()
        {
            return View();
        }
        public ActionResult Ukr()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Vidguk()
        {
            ViewBag.ID = 0;
            return View(db.Reviews);
        }

        [HttpPost]
        public ActionResult Vidguk(Review review)
        {
            ViewBag.ID = 0;
            db.Reviews.Add(review);
            db.SaveChanges();
            Thread.Sleep(150);
            return View("Success");
        }
    }
}
