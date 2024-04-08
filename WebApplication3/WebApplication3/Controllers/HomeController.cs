using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.message = "Trường đại học Nguyễn Trãi";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.message = "Chào Mừng các bạn đến với trường đại học Nguyễn Trãi";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.message = "Thông tin liên hệ Hostline: 0123456789";
            return View();
        }


    }
}