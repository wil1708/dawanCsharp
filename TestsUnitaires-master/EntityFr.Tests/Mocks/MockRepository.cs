using EntityFr.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFr.Tests.Mocks
{
    public class MockRepository : IRepository
    {
        public List<Contact> contacts { get; set; }

        public MockRepository()
        {
            contacts = new List<Contact>();
        }

        public void Delete(int id)
        {
            Contact c = contacts.Find(ct => ct.Id == id);
            if (c != null)
            {
                contacts.Remove(c);
            }
            else
            {
                throw new Exception("Contact introuvable");
            }
           
        }

        public Contact findById(int id)
        {
            Contact c = contacts.Find(ct => ct.Id == id);
            if (c != null)
            {
                return c;
            }
            else
            {
                throw new Exception("Contact introuvable");
            }
        }

        public List<Contact> getAll()
        {
            return contacts;
        }

        public void Insert(Contact c)
        {
            contacts.Add(c);
        }

        public void Update(Contact c)
        {
            Contact contact = contacts.Find(ct => ct.Id == c.Id);
            if (contact != null)
            {
                contact.Nom = c.Nom;
                contact.Prenom = c.Prenom;
                contacts.Insert(contacts.IndexOf(c), contact);
                contacts.Remove(c);
            }
            else
            {
                throw new Exception("Contact introuvable");
            }

        }
    }
}
