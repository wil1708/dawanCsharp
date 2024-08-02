using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        //MVC : Model Vue Control
        UserService service = new UserService();
        // GET: Default
        public ActionResult Index()
        {
            List<Contact> contacts = service.findAll();
            return View(contacts);
        }
    }
}