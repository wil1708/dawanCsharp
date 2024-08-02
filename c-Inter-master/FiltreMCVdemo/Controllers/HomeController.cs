using FiltreMCVdemo.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltreMCVdemo.Controllers
{
    [LoginFilter]
    public class HomeController : Controller
    {
        [AuthorisationFilter("Admin", "Normal")]
        public ActionResult Index()
        {
            return View();
        }

        [AuthorisationFilter("Admin", "Normal","Visiteur")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
       
       [AuthorisationFilter("Admin")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult NonAuthorise()
        {
            return View();
        }
    }
}