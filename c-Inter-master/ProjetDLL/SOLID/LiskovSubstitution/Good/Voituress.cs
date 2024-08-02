using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.SOLID.LiskovSubstitution.Good
{
    public class Voituress : Vehicules
    {
        //Liskov: classe Voiture doit afficher à la console le contenue de la méthode Demmarer de la classe Vehicule
        public override void Demarrer()
        {
            base.Demarrer();
        }

        public void DemarrerVoiture()
        {
            Console.WriteLine("Voiture démarrée.......");
        }

        public void DemarrerVoiture(string str)
        {
            Console.WriteLine("Voiture démarrée......."+str);
        }
    }
}
