using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CalculatriceConsole
{
    public class Module3
    {
        public static string Choix()
        {
            string choix = "";
            do
            {
                Console.Write("Merci de choisir une opération : ");
                choix = Console.ReadLine();
            } while (!(choix == "a" || choix == "s" || choix == "m" || choix == "d"));

            return choix;
        }
    }
}
