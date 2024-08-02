using MVC.DTO;
using MVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        UtilisateurService service = new UtilisateurService();
        // GET: Admin/Login
        public ActionResult Index(int? id)
        {
            UserDTO dto = new UserDTO();
            return View(dto);
        }

        [HttpPost]
        public ActionResult Index(UserDTO dto)
        {
            UserDTO user = service.findByUserNameAndPassword(dto);
            if (ModelState.IsValid)
            {
                if (user != null && user.Id != 0)
                {
                    return RedirectToRoute("Default", new { controller="Produit", action="Index"} );
                }
                else
                {
                    return View(dto);
                }
            }
            else 
            {
            return View(dto);
            }
        }
    }
}