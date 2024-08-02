using _3_MVCApiCLient.ApiClients;
using _3_MVCApiCLient.Filters;
using _3_MVCApiCLient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace _3_MVCApiCLient.Controllers
{
    [LoginFilter]
    public class UsersController : Controller
    {
        private ApiUser api = new ApiUser();
        // GET: Users
        public async Task<ActionResult> Index()
        {
            List<User> lst = await api.AllUsers();
            return View(lst);
        }
        
        public  ActionResult Create()
        {
            return View(new User());

        }
        [HttpPost]
        public async Task<ActionResult> Create(User user)
        {
            await api.AddUser(user);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Edit(int id)
        {
            User user = await api.GetById(id);
            return View(user);
        }
        
        [HttpPost]
        public async Task<ActionResult> Edit(User user)
        {
            await api.UpdateUser(user);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Delete(int id)
        {
            User user = await api.GetById(id);
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<ActionResult> DeleteConfirme(int id)
        {
            await api.DeleteUser(id);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Details(int id)
        {
            User user = await api.GetById(id);
            return View(user);
        }
    }
}