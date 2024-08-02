using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Generic
{
    public class MyClassGeneric<T> //where T: new() // le type T doit contenir un constructeur sans params
                                       // where T : CompteBancaire - T doit héritée de la classe CompteBancaire 
    {
        public T A { get; set; }
        public T B { get; set; }

        public void Permuter()
        {
            T c = A;
            A = B;
            B = c;
        }
    }
}
