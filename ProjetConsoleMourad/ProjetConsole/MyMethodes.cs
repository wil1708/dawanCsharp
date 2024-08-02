using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    public class MyMethodes
    {
        /// <summary>
        /// Méthode qui calcule la somme de 2 entiers
        /// </summary>
        /// <param name="nb1"></param>
        /// <param name="nb2"></param>
        /// <returns></returns>
        public static int Somme(int nb1, int nb2)
        {
            int somme = 0;
            somme = nb1 + nb2;
            return somme; 
        }

        /// <summary>
        /// Methode qui renvoie la somme des éléments d'un tableau d'entiers
        /// </summary>
        /// <param name="tab"></param>
        /// <returns></returns>
        public static int Somme(int[] tab)
        {
            int somme = 0;
            foreach (int item in tab)
            {
                somme += item;
            }
            return somme;
        }

        /// <summary>
        /// Methode afficher
        /// </summary>
        public static void Afficher()
        {
            Console.WriteLine("Methode Afficher de la classe MyMethodes");
        }

        //Overload (surcharge) : la possibilité de définir dans une même classe une méthode qui possède la même signature avec 
        //uniquement le type de paramètre qui change
        //public static void  Afficher(int[] tab)   =====>> signature de la méthode
        public static void  Afficher(int[] tab)
        {
            foreach(var item in tab)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Methode qui retourne le caractère en majuscule
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Majuscule(string str)
        {
            return str.ToUpper();
        }


     

        /// <summary>
        /// Methode qui renvoie l'élément le plus pétit d'un tableau
        /// </summary>
        /// <param name="tab"></param>
        /// <returns></returns>
        public static int MinTableau(int[] tab)
        {
            int min = tab[0];  //Prend le premier élément du tableau
            for(int i = 0; i < tab.Length; i++)
            {
                if(min > tab[i])
                {
                    min = tab[i];
                }
            }
            return min;
        }

        /// <summary>
        /// Methode qui renvoie la moyenne des élements d'un tableau
        /// </summary>
        /// <param name="tab"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Passage de paramètre optionnels : Ce sont des paramètres qui possèdent des valeurs par defaut
        /// et doivent être définis à la fin de la liste des paramètres
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int SommeOptional(int a, int b, int c=10)
        {
            return a + b + c;
        }


        /// <summary>
        /// Méthode qui permute deux entiers
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void PermutDeuxEntier(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        //Methode qui renvoie le nombres de mots contenu dans une chaine
        public static int NombreDeMots(string str)
        {
            str = str.Trim();
            str = str.Replace("  ", "");  //Remplacer les doubles espaces par les simples
            return str.Split(' ').Length;
        }


        //Une methode qui renvoie la chaine inversée
        public static string ChaineInverser(string str)
        {
            string chaineInverser = "";
            for(int i = str.Length - 1; i >=0; i--)
            {
                chaineInverser += str.ElementAt(i);
            }
            return chaineInverser;
        }


        //Methode qui verifie si un mot est un palindrome (ex: sms, sos, anna...)
        public static Boolean VerifPalindrom(string str)
        {
            str = str.Trim();
            str = str.ToLower();
            return ChaineInverser(str).Equals(str);
        }

    }
}
