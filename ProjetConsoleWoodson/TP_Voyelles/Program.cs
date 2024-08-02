using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Voyelles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Compter le nombre de chaque voyelle contenu dans un mot

            //Entrée = Toulouse

            //Sortie
            //Votre mot comporte :
            //0 fois la voyelle e
            //0 fois la voyelle a
            //0 fois la voyelle i
            //2 fois la voyelle u
            //2 fois la voyelle o
            //0 fois la voyelle y

            char[] voyelles = { 'e', 'a', 'i', 'u', 'o', 'y' };
            //nbVoyelles est initialisé avec la taille de voyelles.Length
            int[] nbVoyelles = new int[voyelles.Length];

            //Initialiser le nombre de chaque voyelle  //boucle for
            for(int i = 0; i < nbVoyelles.Length; i++)
            {
                nbVoyelles[i] = 0;
            }


            //Demander la saisie d'un mot - Compter le nombre de chaque voyelle contenue dans le mot fourni -- 2 boucle for
            Console.WriteLine("Veuillez saisir un mot ");
            string saisie = Console.ReadLine();
            saisie = saisie.ToLower();
            for(int i = 0; i < saisie.Length; i++)  
            {
                for(int j = 0; j < voyelles.Length; j++)  
                {
                    if(saisie[i].Equals(voyelles[j]))
                    {
                        nbVoyelles[j]++;       
                    }
                }
            }

            //Affichage -- boucle for 
            Console.WriteLine("Votre mot comporte : ");
            for(int i = 0; i < voyelles.Length; i++)
            {
                Console.WriteLine(nbVoyelles[i] + " fois la voyelle " + voyelles[i]);
            }

            Console.ReadLine();

        }
    }
}
