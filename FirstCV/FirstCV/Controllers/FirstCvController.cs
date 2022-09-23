using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstCV.Controllers
{
    public class FirstCvController : Controller
    {
        // GET: FirstCv
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult AboutMe()
        {
            return View();
        } 
        public ActionResult Education()
        {
            return View();
        } 
        public ActionResult ContactMe()
        {
            return View();
        }

        public ActionResult WorkSection()
        {
            return View();
        }

        public ActionResult Navbar()
        {
            return View();
        }

    }
}