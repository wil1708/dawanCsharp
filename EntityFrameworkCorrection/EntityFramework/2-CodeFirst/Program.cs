using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact c = new Contact();
            c.Nom = "Dawan";
            c.Prenom = "Paris";

            Context db = new Context();
            db.Contacts.Add(c);

            db.SaveChanges();

            Console.WriteLine("Contact inséré...........");
            Console.ReadKey();
        }
    }
}
