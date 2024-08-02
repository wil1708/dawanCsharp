using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.SOLID.OpenClose.Good
{
    public class Triangle : IForme
    {
        public double Base { get; set; }
        public double Hauteur { get; set; }

        public double Surface()
        {
            return (Base * Hauteur) / 2;
        }
    }
}
