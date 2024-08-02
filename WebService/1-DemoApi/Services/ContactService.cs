using _1_DemoApi.Models;
using _1_DemoApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1_DemoApi.Services
{

    public class ContactService : IContactService
    {
        private IContactRepository repo;

        public ContactService(IContactRepository repo)
        {
            this.repo = repo;
        }
        //GetAll
        //FindById
        //Delete
        //Update

        public List<Contact> GetAll()
        {
            return repo.GetAll();
        }

        public Contact FindById(int id)
        {
            return repo.FindById(id);
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