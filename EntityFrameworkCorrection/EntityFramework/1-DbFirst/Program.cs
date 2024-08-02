using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DbFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            /*employe e = new employe();
            e.Id = 1;
            e.nom = "Dawan";
            e.prenom = "Bordeaux"*/;

            Contact c = new Contact();
            c.nom = "Dawan";

            DbFirstEntities db = new DbFirstEntities();
            db.Contact.Add(c);

            //la méthode SaveChanges : execute les commandes SQL (mise à jours de la BD)
            db.SaveChanges();

            Console.WriteLine("Contact ajouté à la BD.....");
            Console.ReadKey();
        }
    }
}
