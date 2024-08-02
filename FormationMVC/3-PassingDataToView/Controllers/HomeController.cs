using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_PassingDataToView.Controllers
{
    public class HomeController : Controller
    {
        /*public ActionResult Index(int? id)
        {
            //ViewData : un dictionnaire d'objets (clé, valeur), il contient donc des paires clé-valeur où chaque clé doit être une chaine de caractère
            //ViewBag : C'est le même objet que ViewData
            //Les deux transfèrent uniquement des données du controleur à la vue et non l'inverse
            //Les deux : leur cycle de vie est limité à la requête - une fois la réponse envoyée vers le navigateur, ces 2 objets sont remis à 0 par le serveur

            if (id.HasValue)
            {
                ViewData["ID"] = id.Value;
            }
            else
            {
                ViewData["ID"] = 0;
            }

            if (id.HasValue)
            {
                ViewBag.Id = id.Value;
            }
            else
            {
                ViewBag.Id = 0;
            }

            //TempData est utilisé pour transférer des données de la vue vers le contrôleur, et du contrôleur vers la vue ou d'une méthode d'action du même contrôleur ou d'un contrôleur différent
            //TempData stocke les données temporairement, et les supprime automatiquement après avoir récupéré une valeur
            //Nous allons voir aussi, bien que TempData supprime une clé-valeur, une fois récupéré, nous pouvons toujours la conserver pour la demande suivante en appelant la méthode TempData.Keep()

            if (id.HasValue)
            {
                TempData["ID"] = id.Value;
            }
            else
            {
                TempData["ID"] = 0;
            }

            TempData.Keep(); //permet de maintenir le contenu de TempData après consommation (après réponse HTTP)

            return View();
        }*/

        //GET
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string nom)
        {
            ViewBag.Nom = nom;
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