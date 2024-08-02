using _2_DemoController.Models;
using _2_DemoController.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace _2_DemoController.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //1-Une action peut retourner une autre vue
            //Action avec un résultat de type ViewResult
            /*return View("Contact");*/

            //Elle permet d'envoyer au client un ordre de redirection vers l'URL qui est dans le paramètre de la méthode
            //Action avec un résultat de type RedirectResult
            /*return Redirect("/Home/Contact");*/

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            //3-
            /*return RedirectToAction("Index", "Test", new { nom = "Dawan", prenom = "Jehann" });*/

            //4-Fais la même chose que la précédente, en indiquant ici le nom de la route
            //Il prendra par défaut les valeurs qu'il y a dans les paramètres nom et prenom définis dans la route
            /*return RedirectToRoute("ContactDetails");*/

            //5- La méthode File retourne un type FilePathResult
            //Server.MapPath permet de récupérer le chemin absolu du fichier
            /*return File(Server.MapPath("~/Demo.txt"), "text/plain", "test.txt");*/

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            //6- la méthode Content retourne un type ContentResult
            /*return Content("Ceci est le contenu de l'action contact");*/

            //7- retourne une chaine de caractère de type XML
            /*return Content("<Personne><nom>Dawan</nom><prenom>Jehann</prenom></Personne>", "text/xml", Encoding.UTF8);*/

            //8-
            /*return null;*/

            //9-Action avec un résultat de type JavaScriptResult
            /*return JavaScript("alert('Test de la methode return JavaScript')");*/

            Personne p = new Personne() { Nom = "Dawan", Prenom = "Jehann" };
            //Action avec un résultat de type JsonResult
            /*return Json(p, JsonRequestBehavior.AllowGet);*/

            string str = MyJsonTool.ToJson<Personne>(p);
            byte[] contenu = Encoding.UTF8.GetBytes(str);

            //10-Action avec un résultat de type FileContentResult
            /*return File(contenu, "application/json", "personne.json");*/

            //12-Action avec un résultat de type HttpNotFoundResult, hérite de HttpStatusCodeResult
            /*return HttpNotFound();*/

            //13-Action avec un résultat de type HttpStatusCodeResult
            /*return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Mauvaise requête");*/

            //14- Action avec un résultat de type HttpUnauthorizedResult, hérite de HttpStatusCodeResult
            return new HttpUnauthorizedResult("Autorisation refusée");
            /*return View();*/
        }
    }
}