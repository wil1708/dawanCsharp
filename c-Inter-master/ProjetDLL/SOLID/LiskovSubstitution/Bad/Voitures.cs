using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.SOLID.LiskovSubstitution.Bad
{
    public class Voitures : Vehicule
    {
        public void Vidange()
        {
            Console.WriteLine("Vidange voiture............");
        }


        public new void Demarrer()
        {
            Console.WriteLine("Voiture démarrée..............");
        }


    }
}
