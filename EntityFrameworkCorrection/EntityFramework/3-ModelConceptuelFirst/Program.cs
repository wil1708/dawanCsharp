using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ModelConceptuelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Produit p = new Produit();
            
            ModelFirstContainer bd = new ModelFirstContainer();
            bd.ProduitSet.Add(p);

            bd.SaveChanges();
        }
    }
}
