using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.SOLID.OpenClose.Good
{
    public class Sphere : IForme
    {
        public double Rayon { get; set; }

        public double Surface()
        {
            return 4 * Math.PI * Math.Pow(Rayon,2);
        }
    }
}
