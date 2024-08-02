using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Polymorphisme
{
    public class Chaise : IPliable
    {
        public string Deplier()
        {
            return "Déplier";
        }

        public string Plier()
        {
            return "plier";
        }
    }
}
