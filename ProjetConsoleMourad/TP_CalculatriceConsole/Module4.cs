using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CalculatriceConsole
{
    public class Module4
    {
        public static void Switch(int valeur1, int valeur2, string choix)
        {
            switch (choix)
            {
                case "a":
                    Console.WriteLine(valeur1 + " + " + valeur2 + " = " + (valeur1 + valeur2));
                    break;
                case "s":
                    Console.WriteLine(valeur1 + " - " + valeur2 + " = " + (valeur1 - valeur2));
                    break;
                case "m":
                    Console.WriteLine(valeur1 + " * " + valeur2 + " = " + (valeur1 * valeur2));
                    break;
                case "d":
                    Console.WriteLine(valeur1 + " / " + valeur2 + " = ");
                    Console.WriteLine("Valeur exacte : " + (valeur1 / valeur2));
                    Console.WriteLine("Reste de la division: " + (valeur1 % valeur2));
                    break;
            }
        }

    }
}
