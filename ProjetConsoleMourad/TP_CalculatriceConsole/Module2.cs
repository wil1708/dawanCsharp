using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CalculatriceConsole
{
    public class Module2
    {
        public static int Valeur()
        {
           
            int valeur = 0;
            do
            {
                try
                {
                    Console.WriteLine("Merci de saisir le premier nombre : ");
                    valeur = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("La valeur choisie n'est pas correcte");
                }

            } while (true);
            return valeur;
        }
    }
}
