using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.DesignPattern.Creation.Factory
{
    public class Triangle : IShape
    {
        private double Hauteur;
        private double Base;

        public Triangle(double hauteur, double bases)
        {
            Hauteur = hauteur;
            Base = bases;
        }

        public Triangle(double hauteur)
        {
            Hauteur = hauteur;
        }

        public double Surface()
        {
            return (Base * Hauteur) / 2;
        }
    }
}
