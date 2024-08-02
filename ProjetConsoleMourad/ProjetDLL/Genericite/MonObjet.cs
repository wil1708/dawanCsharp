using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Genericite
{
    public class MonObjet
    {
      
        public Object obj { get; set; }

        public MonObjet(object obj)
        {
            this.obj = obj;
        }

        public override string ToString()
        {
            return "Mon objet (obj = " + obj + ")";
        }
    }
}
