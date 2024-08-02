using EntityFr.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFr.Controllers
{
    public class HomeController
    {
        private ContactService service;

        public HomeController(ContactService service)
        {
            this.service = service;
        }

        public List<Contact> Index()
        {
            return service.getAll();
        }

        public Contact Edit(int id)
        {
            return service.findById(id);
        }
    }
}
