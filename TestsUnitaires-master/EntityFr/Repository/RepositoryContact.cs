using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFr.Repository
{
    public class RepositoryContact : IRepository
    {
        public void Delete(int id)
        {
            using (MyContext context = new MyContext())
            {
                Contact c = context.Contacts.Find(id);
                if ( c == null)
                {
                    throw new Exception("Delete Contact introuvable!");
                }
                else
                {
                    context.Contacts.Remove(c);
                    context.SaveChanges();
                }
            }
        }

        public Contact findById(int id)
        {
            using (MyContext context = new MyContext())
            {
                Contact c = context.Contacts.Find(id);
                if (c == null)
                {
                    throw new Exception("FindByID Contact introuvable!");
                }
                else
                {
                    return c;
                }
            }
        }

        public List<Contact> getAll()
        {
            List<Contact> lst = new List<Contact>();
            using (MyContext context = new MyContext())
            {
                lst = context.Contacts.ToList();
            }
            return lst;
        }

        public void Insert(Contact c)
        {
            using (MyContext context = new MyContext())
            {
                context.Contacts.Add(c);
                context.SaveChanges();
            }
        }

        public void Update(Contact c)
        {
            using (MyContext context = new MyContext())
            {
                Contact contact = context.Contacts.Find(c.Id);
                if (contact == null)
                {
                    throw new Exception("Contact introuvable!");
                }
                else
                {
                    contact.Nom = c.Nom;
                    contact.Prenom = c.Prenom;
                    context.SaveChanges();
                }
            }
        }
    }
}
