using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExoMVC.DTO;
using ExoMVC.Filters;
using ExoMVC.Models;
using ExoMVC.Services;
using PagedList;
using PagedList.Mvc;

namespace ExoMVC.Controllers
{
    [LoginFilter]
    public class UtilisateurController : Controller
    {
        private UtilisateurService service = new UtilisateurService();

        // Pour la pagination
        //1- Via Nuget récupérer PagedList.MVC
        //2-

       
        public ActionResult Index(string search, int? i, string sortBy)
        {
            List<UserDTO> lst = new List<UserDTO>();

            //Filtre
            if (search != null)
                lst = service.getAllUsers().Where(u => u.UserName.Contains(search)).ToList();
            else
                lst = service.getAllUsers();

            //Tri
            switch (sortBy)
            {
                case "nameAsc":
                    lst = lst.OrderBy(x => x.UserName).ToList();
                    break;
                case "nameDesc":
                    lst = lst.OrderByDescending(x => x.UserName).ToList();
                    break;
                case null:
                    break;
                default:
                    break;
            }


            //int x = i ?? 5;
            //if (i==null)
            //{
            //    x = 5;
            //}
            return View(lst.ToPagedList(i ?? 1, 2));
        }

        
        // GET: Utilisateur/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserDTO userDTO = service.getUserDTOById(id);
            if (userDTO == null)
            {
                return HttpNotFound();
            }
            return View(userDTO);
        }

        // GET: Utilisateur/Create
        
        public ActionResult Create()
        {
            return View(new UserDTO());
        }
        
        // POST: Utilisateur/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UserName,Password,isAdmin,Email")] UserDTO userDTO, HttpPostedFileBase Photo)
        {
            if (ModelState.IsValid)
            {
                userDTO.Photo = userDTO.UserName + Path.GetExtension(Photo.FileName);
                Photo.SaveAs(Server.MapPath("~/Content/images/") + userDTO.Photo);

                service.Add(userDTO);
                return RedirectToAction("Index");
            }

            return View(userDTO);
        }

        
        // GET: Utilisateur/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserDTO userDTO = service.getUserDTOById(id);
            if (userDTO == null)
            {
                return HttpNotFound();
            }
            else
            {
                Session["image"] = userDTO.Photo;
                return View(userDTO);

            }

        }
        
        // POST: Utilisateur/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UserName,Password,isAdmin,Email")] UserDTO userDTO, HttpPostedFileBase Photo)
        {
            if (ModelState.IsValid)
            {
                if (Photo != null)
                {
                    userDTO.Photo = userDTO.UserName + Path.GetExtension(Photo.FileName);
                    Photo.SaveAs(Server.MapPath("~/Content/images/") + userDTO.Photo);
                }
                else
                {
                    userDTO.Photo = (string)Session["image"];
                    Session.Remove("image");
                }
                service.Update(userDTO);
                return RedirectToAction("Index");
            }
            return View(userDTO);
        }
        
        // GET: Utilisateur/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserDTO userDTO = service.getUserDTOById(id);
            if (userDTO == null)
            {
                return HttpNotFound();
            }
            return View(userDTO);
        }
        
        // POST: Utilisateur/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            service.DeleteUserDTO(id);
            return RedirectToAction("Index");
        }

       
        
    }
}
