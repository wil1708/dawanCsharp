using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Polymorphisme
{
    public class Table : IPliable
    {
        public string Deplier()
        {
            return "Table dépliée....";
        }

        public string Plier()
        {
            return "Table pliée.....";
        }
    }
}
