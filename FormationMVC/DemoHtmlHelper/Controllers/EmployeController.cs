using DemoHtmlHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DemoHtmlHelper.Models.Employe;

namespace DemoHtmlHelper.Controllers
{
    public class EmployeController : Controller
    {
        // GET: Employe
        public ActionResult Index()
        {
            //Création d'une liste de département 
            List<Departement> deps = new List<Departement>()
            {
                new Departement{DepartementId = 1, Nom = "Informatique"},
                new Departement{DepartementId = 1, Nom = "Recherche"},
                new Departement{DepartementId = 1, Nom = "Developpement"}

            };

            SelectList sl = new SelectList(deps, "DepartementId", "Nom");

            //Via TempData, on transmet la liste des départements vers la vue, comme un eliste déroulante, un DropDownList
            //Dans la vue, on récupèrera cette liste à partir de la clé "DepartementId"
            TempData["DepartementId"] = sl;
            TempData.Keep(); //Keep permet de maintenir le contenu de TempData après consommation (après la réponse HTTP)
            Employe emp = new Employe()
            {
                Id = 1,
                Nom = "Dawan",
                Salaire = 1000,
                IsActif = true,
                Email = "employe@dawan.fr",
                DateEntree = DateTime.Now,
                Type = EmployeType.JUNIOR
            };
            return View(emp);
        }

        [HttpPost]
        public ActionResult Index (Employe emp)
        {
            //Vider le contenu du ModelState afin de mettre à jour le model à partir de l'action Index
            ModelState.Clear();
            emp.Nom = "Pires";


            return View(emp);
        }
    }
}