using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Genericite
{
    public class ClasseGeneric<T>
    {
        public T data { get; set; }

        public ClasseGeneric(T data)
        {
            this.data = data;
        }

        public override string ToString()
        {
            return "Mon objet (data = " + data + ")";
        }
    }
}
