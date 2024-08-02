using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Association
{
    public class Adresse
    {
        public int Num { get; set; }
        public string Street { get; set; }

        public override string ToString()
        {
            return Num + " " + Street;
        }
    }
}
