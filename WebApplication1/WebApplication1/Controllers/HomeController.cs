using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.message = "Chào mừng bạn đến với ASP.NET";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.message = "Đây là Trang About";
            return View();
        }

    }
}