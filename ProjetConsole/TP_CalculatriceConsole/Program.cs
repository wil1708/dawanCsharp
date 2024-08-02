using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CalculatriceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration des variables
            string choix = "";
            int valeur1 = 0;
            int valeur2 = 0;

            //Afficher le menu
            Console.WriteLine("********************Calculatrice Console****************************");
            Console.WriteLine("---------------Opération possible----------------------");
            Console.WriteLine("Addition : 'a'");
            Console.WriteLine("Soustraction : 's'");
            Console.WriteLine("Multiplication : 'm'");
            Console.WriteLine("Division : 'd'");

            //Choix de l'opérateur mathématique
            do
            {
                Console.WriteLine("Merci de choisir une opération : ");
                choix = Console.ReadLine();
                Console.WriteLine(choix);
            } while(!(choix == "a" || choix == "s" || choix == "m" || choix == "d")); //!(VRAI) = FAUX
            

            //Récupérer la valeur 1
            do
            {
                try
                {
                    Console.WriteLine("Merci de saisir le premier : ");
                    valeur1 = Convert.ToInt32(Console.ReadLine());
                    break;
                } 
                catch(Exception e)
                {
                    Console.WriteLine("La valeur choisie n'est pas correcte");
                }
                
            } while (true);
            //Récupérer la valeur 2
            do
            {
                try
                {
                    Console.WriteLine("Merci de saisir le deuxième : ");
                    valeur2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("La valeur choisie n'est pas correcte");
                }

            } while (true);

            switch (choix)
            {
                case "a":
                    Console.WriteLine(valeur1 + " + " + valeur2 + " = " + (valeur1 + valeur2));
                    break;
                case "s":
                    Console.WriteLine(valeur1 + " + " + valeur2 + " = " + (valeur1 - valeur2));
                    break;
                case "m":
                    Console.WriteLine(valeur1 + " + " + valeur2 + " = " + (valeur1 * valeur2));
                    break;
                case "d":
                    Console.WriteLine(valeur1 + " / " + valeur2 + " = ");
                    Console.WriteLine("Valeur exacte : " + (valeur1 / valeur2));
                    Console.WriteLine("Reste de la division: " + (valeur1 % valeur2));
                    break;
            }

            Console.ReadLine();
        }
    }
}
