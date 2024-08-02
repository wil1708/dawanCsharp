using _1_DemoApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _1_DemoApi.Repositories
{
    public class ContactRepository : IContactRepository
    {
        //GetAll
        //FindById
        //Delete
        //Update
        private MyContext context;
        public ContactRepository(MyContext context)
        {
            this.context = context;
        }
        public List<Contact> GetAll()
        {
            // renvoie la liste des contacts sans la sauvegarder dans le cache du contexte
            return context.Contacts.AsNoTracking().ToList();
        }

        public Contact FindById(int id)
        {
            Contact c = context.Contacts.AsNoTracking().FirstOrDefault(ct => ct.Id == id);
            return c;
        }

        public void Update(Contact c)
        {
            if (context.Entry(c).State == EntityState.Detached)
            {
                context.Entry(c).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {

            Contact ct = context.Contacts.Find(id);
            if (ct != null)
            {
                context.Contacts.Remove(ct);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Contact introuvable");
            }
        }

        public void Insert(Contact c)
        {
            context.Contacts.Add(c);
            context.SaveChanges();
        }
    }
}