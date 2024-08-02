using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.SOLID.OpenClose.Good
{
    public class SurfaceCalculateur
    {
        public static double Surface(IForme forme)
        {
            return forme.Surface();
        }
    }
}
