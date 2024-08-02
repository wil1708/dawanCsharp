using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Encapsulation
{
    public class Rectangle
    {
        //Dans certaines applications sensibles - les champs et les propriétés sont private
        //L'accès aux champs doit forcément passer par une méthode
        
        private double hauteur;

        private double Hauteur
        {
            get { return hauteur; }
            set { hauteur = value; }
        }

        private double largeur;

        private double Largeur
        {
            get { return largeur; }
            set { largeur = value; }
        }

        public Rectangle(double hauteur, double largeur)
        {
            Hauteur = hauteur;
            Largeur = largeur;
        }

        //Définir une méthode d'accès aux champs
        public void Redim(double hauteur, double largeur)
        {
            Hauteur = hauteur;
            Largeur = largeur;
        }
    }
}
