using EntityFr.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFr.Services
{
    public class ContactService
    {
        private IRepository repo;

        public ContactService(IRepository repo)
        {
            this.repo = repo;
        }

        public List<Contact> getAll()
        {
            return repo.getAll();
        }

        public Contact findById(int id)
        {
            return repo.findById(id);
        }

        public void Delete(int id)
        {
            repo.Delete(id);
        }

        public void Update(Contact c)
        {
            repo.Update(c);
        }

        public void Insert(Contact c)
        {
            repo.Insert(c);
        }

    }
}
