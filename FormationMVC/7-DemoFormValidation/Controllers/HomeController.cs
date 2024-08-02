using _7_DemoFormValidation.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _7_DemoFormValidation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Employe emp = new Employe();

            return View(emp);
        }

        //DataBinding : à partir du contenu du formulaire le framework a construit un objet de type employé (un type complexe)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Exclude = "Photo")]Employe emp, HttpPostedFileBase photo)
        {
            //vérifier l'extension du fichier photo
            string extension = Path.GetExtension(photo.FileName);
            if(extension.Equals(".png") || extension.Equals(".jpg") || extension.Equals(".jpeg"))
            {
                //On teste si le modèle est valide
                //Le modèle de l'action est formé de l'ensemble de ses paramètres
                //Le modèle est valide si tous les paramètres ont pu obtenir une valeur de la requête ou bien
                //La valeur null si le type du paramètre le permet
                if (ModelState.IsValid)
                {
                    //On va sauvegarder notre image dans un dossier Photos, qui se trouve dans un dossier Content
                    string fileName = emp.UserName + Path.GetExtension(photo.FileName); ;
                    emp.Photo = fileName;
                    string path = Server.MapPath("~/Content/Photos/" + fileName);
                    photo.SaveAs(path);

                    //Sauvegarder l'employé dans la base - context.Employe.Add(emp).SaveChanges();

                    //On retourne dans la vue contact le model emp
                    return View("Contact", emp);
                }
                else
                {
                    return Content("L'extension de la photo doit être : .png, .jpg ou .jpeg");
                }     
            }
            return View(emp);
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