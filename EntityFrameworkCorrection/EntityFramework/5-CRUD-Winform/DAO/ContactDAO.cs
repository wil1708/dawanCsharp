using _5_CRUD_Winform.Metier;
using _5_CRUD_Winform.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_CRUD_Winform.DAO
{
    public class ContactDAO : IContact
    {

        public void Delete(int id)
        {
            //using with ressources

            using (MyDbContext context = new MyDbContext())
            {
                Contact c = context.Contacts.Find(id);
                MessageBox.Show("Etat de l'objet contact après Find: " + context.Entry(c).State); //Unchanged
                if (c != null)
                {
                    context.Contacts.Remove(c);
                    MessageBox.Show("Etat de l'objet contact après Remove: " + context.Entry(c).State); //Deleted

                    //Etat de l'objet dans le context = Delete
                    //context.Entry(c).State = System.Data.Entity.EntityState.Deleted;

                    context.SaveChanges(); //DELETE
                }
                else
                {
                    ////message d'erreur
                }
            } //le bloc Using fait appel à la méthode dispose qui libère la ressource
           

           /* MyDbContext context = new MyDbContext();
            Contact c = context.Contacts.Find(id);
            if(c != null)
            {
                context.Contacts.Remove(c);
                //Etat de l'objet dans le context = Delete
                //context.Entry(c).State = System.Data.Entity.EntityState.Deleted;

                context.SaveChanges();
            }
            else
            {
                ////message d'erreur
            }

            context.Dispose();*/
            
        }

        public Contact findById(int id)
        {
            Contact c = null;
            using (MyDbContext context = new MyDbContext())
            {
                c = context.Contacts.Find(id);
            }

            return c;
        }

        public List<Contact> getAll()
        {
            List<Contact> list = new List<Contact>();
            using (MyDbContext context = new MyDbContext())
            {
                list = context.Contacts.ToList();
            }

            return list;
        }

        public void Insert(Contact c)
        {
            using (MyDbContext context = new MyDbContext())
            {
                context.Contacts.Add(c);

                MessageBox.Show("Etat de l'objet contact après Add: " + context.Entry(c).State); //Added

                context.SaveChanges();
            }
        }

        public void Update(Contact c)
        {
            using (MyDbContext context = new MyDbContext())
            {
              /*  //Option1:
                if(context.Entry(c).State == EntityState.Detached)
                {
                    context.Contacts.Attach(c); //Attach: charge le contact dans le context - Etat = Unchanged
                    context.Entry(c).State = EntityState.Modified;

                    //UPDATE Contact set nom=c.Nom, prenom=c.prenom where id=c.Id
                    context.SaveChanges();
                }*/

               //Option2:
                Contact contactDB = context.Contacts.Find(c.Id); //
                if(contactDB != null) // si != null : etat Unchanged
                {
                    contactDB.Nom = c.Nom;
                    contactDB.Prenom = c.Prenom;

                    //Appel des setters => etat = Modified
                    context.SaveChanges();
                }
                

            }
        }
    }
}
