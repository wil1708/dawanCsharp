using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.TypeDynamic
{
    public class DynamicClass
    {
        public static dynamic Addition(dynamic x, dynamic y)
        {
            return x + y;
        }
    }
}
