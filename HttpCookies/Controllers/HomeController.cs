using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HttpCookies.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var name = "opemipo";
            var named = "mipo";
            HttpCookie cookie = new HttpCookie("opecookie");
           
///////////////////////////////////////////
          
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