using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Delegates
{
    public class MyDelegate
    {

        //Définir une signature (prototype) de méthode
        public delegate int Operation(int x, int y);

        public static int Somme(int x, int y)
        {
            return x + y;
        }

        public static int Soustraction(int x, int y)
        {
            return x - y;
        }

     
    }
}
