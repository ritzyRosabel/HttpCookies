using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace HttpCookies.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var name = "opemipo";
       

            HttpCookie cookie = new HttpCookie("cookie");
            cookie["username"] = name; 
            ViewBag.cookieds = cookie["username"];
            ViewBag.cooky = cookie.Value;
            Response.Cookies.Add(cookie);

            ///////////////////////////////////////////

            
            Response.Cookies.Get("usernames");
            if (cookie == null)
            {
                cookie["ope"] = "kola";
                ViewBag.cookie = cookie.Value;

            }
            else
            {
                cookie["mipo"] = "kola";
                ViewBag.sb = "hello";
                ViewBag.cookid = cookie.Value;

            }

            Response.Cookies.Remove("username");
            ViewBag.cookied = cookie.Value;

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