using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculateur.DLL
{
    public class Calculateurs
    {
        public static int Division(int numerateur, int denominateur)
        {
            if(denominateur == 0)
            {
                throw new DivideByZeroException("Tentative de division par zéro........");
            }
            int resultat = numerateur / denominateur;
            return resultat;
        }

        public static int chaineLength(string chaine)
        {
            return chaine.Length;
        }

        public static int nombreMots(string chaine)
        {
            return chaine.Trim().Split(' ').Length;
        }

        public static int sommeTab(int[] tab)
        {
            int somme = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                somme += tab[i];
            }

            return somme;
        }

        //Méthode private static
        //2 options pour tester une méthode privée
        //Option 1:
        // - utiliser la méthode privée dans une méthode public - tester la méthode public

        //Option2: tester la méthode privée elle même

        private static bool IsPositif(int number)
        {
            return number > 0;
        }

        //Option1:

        public static int Add(int x, int y)
        {
            if (IsPositif(x) && IsPositif(y))
            {
                return x + y;
            }
            else
            {
                throw new ArgumentException("Sont authorisés uniquement les nombres positifs");
            }
        }

        //Méthode privée non static
        private bool IsNegatif(int number)
        {
            return number < 0;
        }

        [ExcludeFromCodeCoverage]
        public static int maMethode()
        {
            return 5;
        }

    }
}

//Exo: 
//1- méthode qui renvoie le nombre de caractères d'une chaine de char
//2- méthode qui renvoie le nombre de mots d'une chaine
//3- méthode qui renvoie la somme des éléments d'un tableau de INT

//Fournir les tests unitaires