using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MySqlDbFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Produit p = new Produit() { Description = "PC Dell", Quantite = 10 };
            MyContext context = new MyContext();
            context.Produits.Add(p);
            context.SaveChanges();
            Console.WriteLine("Produit inséré dans la base....");
            Console.ReadKey();
        }
    }
}
