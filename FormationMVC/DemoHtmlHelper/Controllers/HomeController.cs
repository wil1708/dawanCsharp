using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoHtmlHelper.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Création d'une listItem qui sera affichée dans la vue, via un dropdownlist (une liste déroulante)
            List<SelectListItem> formations = new List<SelectListItem>()
            {
                new SelectListItem() { Text="ASP.NET", Value="1"},
                new SelectListItem() { Text = "JAVA", Value = "2" },
                new SelectListItem() { Text = "Oracle", Value = "3" }

            };
            //Notre liste de collections ici formations, affectées au ViewBag permettra de remplir dynamiquement notre DropDownList
            ViewBag.Formations = formations;

            return View();
        }

        [HttpPost]
        public ActionResult Bonjour(string nom, string prenom, string poste, int formations)
        {
            List<SelectListItem> lstformations = new List<SelectListItem>()
            {
                new SelectListItem() { Text="ASP.NET", Value="1"},
                new SelectListItem() { Text = "JAVA", Value = "2" },
                new SelectListItem() { Text = "Oracle", Value = "3" }

            };

            return Content("Nom: " + nom + " Prenom: " + prenom + " Poste: " + poste + " Formation: " + lstformations.ElementAt(formations - 1).Text);
        }

        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        public ActionResult About(string nom)
        {
            ViewBag.Nom = nom;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}