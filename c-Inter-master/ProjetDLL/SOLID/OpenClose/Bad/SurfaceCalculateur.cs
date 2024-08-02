using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.SOLID.OpenClose.Bad
{
    public class SurfaceCalculateur
    {
        //Open-Close
        /*ouverte à l'extension et fermée à modification
         * A chaque d'une forme géométrique (traingle), on doit ajouter une nouvelle méthode qui calcule la surface de cette forme
         * Cette classe n'est pas fermée à la modification
         */

        public double RectangleSurface(Rectangles rec)
        {
            return rec.Hauteur * rec.Largeur;
        }

        public double CercleSurface(Cercle c)
        {
            //PI * rayon au carré
            return Math.PI * Math.Pow(c.Rayon, 2);
        }
    }
}
