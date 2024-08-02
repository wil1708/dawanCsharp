using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialisationAndCleanup
{
    public class Rectangle
    {
        public double Hauteur { get; set; }
        public double Largeur { get; set; }

        

        public double Surface()
        {
            return Hauteur * Largeur;
        }

        public double Perimetre()
        {
            return 2 * (Hauteur + Largeur);
        }
    }
}
