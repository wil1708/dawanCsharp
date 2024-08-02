using _1_DemoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace _1_DemoApi.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            ViewBag.Title = "Home Page";

            List<Contact> lst = await AllContacts();

            return View(lst);
        }

        public async Task<ActionResult> CSV()
        {
            return File(await ContactCSV(), "text/plain", "contact.csv");
        }

        //Appeler l'API - récupérer la liste des contacts - et l'afficher dans la vue Index
        //L'appel d'une se fait en utilisant un client Http

        //GEt api/Contact
        static async Task<List<Contact>> AllContacts()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage res = await client.GetAsync("http://localhost:49280/api/Contact");
            if (res.IsSuccessStatusCode)
            {
                return await res.Content.ReadAsAsync<List<Contact>>();
            }
            return null;
        }

        static async Task<byte[]> ContactCSV()
        {
            HttpClient client = new HttpClient();
            return await client.GetByteArrayAsync("http://localhost:49280/api/Contact?format=csv");
            
        }
    }
}
