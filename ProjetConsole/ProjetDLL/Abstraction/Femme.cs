using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Abstraction
{
    public class Femme : Personne
    {
        public override void Identite()
        {
            Console.WriteLine("Je suis une femme"); 
        }
    }
}
