using _4_DemoActionFilter.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_DemoActionFilter.Controllers
{
    //2-
    //[Authorize]
    public class HomeController : Controller
    {
        [LogFilter]
        //3- permet d'autoriser l'accès à des utilisateurs non authentifiés
        [AllowAnonymous] 
        //4-Ce filtre cache la sortie d'une action du controller pendant un certain temps
        [OutputCache(Duration = 10)] //Mise en cache du serveur pour 10 secondes du contenu de TempData
        public ActionResult Index()
        {
            TempData["Heure"] = DateTime.Now.ToLongTimeString();
            return View();
        }

        //1- Ce filtre gère les cas d'autorisation
        //[Authorize] //Action accessible uniquement par les users connectés
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(true)] //à true (par défaut) le framework prend en compte les attaques XSS
        public ActionResult Index(string demo)
        {
            ViewBag.Demo = demo;
            return View();
        }

        [HandleError] //si l'action Contact génère une erreur la page erreur globale sera affichée (error.cshtml)
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            throw new Exception("Mon exception");

            /*return View();*/
        }
    }
}