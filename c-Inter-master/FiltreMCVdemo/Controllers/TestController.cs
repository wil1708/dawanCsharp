using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltreMCVdemo.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        
        public ActionResult Index()
        {
            throw new Exception();
        }

        public ActionResult Erreur404()
        {
            return View();
        }
    }
}