using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    class MyMethodes
    {
        /// <summary>
        /// Méthode qui calcule la somme de 2 entiers
        /// </summary>
        /// <param name="nb1"></param>
        /// <param name="nb2"></param>
        /// <returns></returns>
        public static int Somme(int nb1, int nb2)
        {
            return nb1 + nb2;
        }
        //Methode afficher
        public static void Afficher()
        {
            Console.WriteLine("Methode Afficher la classe MyMethodes");
        }

        //Overload (surcharge) : la possibilité de définir dans une même classe une méthode qui possède la même signature avec 
        //uniquement le type de paramètre qui change
        //public static void  Afficher(int[] tab)   =====>> signature de la méthode
        public static void Afficher(int[] tab)
        {
            foreach (var item in tab)
            {
                Console.WriteLine(item);
            }
        }

        //1 - Methode qui retourne la chaine de caractère en majuscule
        public static string Majuscule(string str)
        {
            return str.ToUpper(); 
        }
        //2- Methode qui renvoie l'élément le plus petit d'un tableau
        public static int Somme(int[] tab)
        {
            int somme = 0;
            foreach(int item in tab)
            {
                somme += item;
            }
            return somme;
        }
        /// <summary>
        /// Methode qui renvoie l'élément le plus petit d'un tableau
        /// </summary>
        /// <param name="tab"></param>
        /// <returns></returns>
        public static int MinTableau(int[] tab)
        {
            int min = tab[0];
            for(int i = 0; i < tab.Length; i++)
            {
                if(min > tab[i])
                {
                    min = tab[i];
                }
            }
            return min;
        }

        public static double MoyenneTableau(int[] tab)
        {
            double sum = 0.0;
            foreach(var item in tab)
            {
                sum += item;
            }
            double moyenne = sum / tab.Length;
            return moyenne;
        }

        //Passage de paramètre optionnel : ce sont des paramètres qui possèdent des valeurs par défaut et doivent être définis à la fin de la liste des paramètres
        public static int SommeOptional(int a, int b, int c = 10)
        {
            return a + b + c;
        }
        //Méthode qui permute deux entiers
        public static void Inverser( ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        //Methode qui renvoie le nombre de mots contenu dans une chaine
        public static int NombreDeMots(string str)
        {
            str = str.Trim();
            str = str.Replace("  ", ""); //Remplacer les doubles espaces par les simples
            return str.Split(' ').Length;
        }

        //Une methode qui renvoie la chaine inversée
        public static string ChaineInverser(string str)
        {
            string chaineInverser = "";
            for(int i = str.Length - 1; i >= 0; i--)
            {
                chaineInverser += str.ElementAt(i);
            }
            return chaineInverser;
        }



        //Methode qui vérifie si un mot est un palindrome (ex: sms, sos, Anna...)
        public static Boolean VerifPalindrome(string str)
        {
            str = str.Trim();
            str = str.ToLower();
            return ChaineInverser(str).Equals(str);
        }

    }
}
