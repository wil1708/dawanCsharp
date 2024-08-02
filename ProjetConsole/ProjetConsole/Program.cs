using ProjetDLL;
using ProjetDLL.Abstraction;
using ProjetDLL.Association;
using ProjetDLL.Encapsulation;
using ProjetDLL.Genericite;
using ProjetDLL.Heritage;
using ProjetDLL.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProjetConsole
{
    class Program
    {
        /// <summary>
        /// Le point d'entrée du programme
        /// </summary>
        /// <param name="args">Les arguments du programme</param>
        static void Main(string[] args)
        {
            /*Ceci
             * est
             * un commentaire
             * multiligne*/

            //Ceci est un commentaire sur une seule ligne

            //Console.Write("Bonjour");
            Console.WriteLine("Hello World");

            Complex c = Complex.One;
            Console.WriteLine(c);
            Console.WriteLine("Partie réelle : " + c.Real);
            Console.WriteLine("Partie imaginaire : " + c.Imaginary);

            #region "Variable"
            //Zone mémoire qui va contenir une valeur typée
            //Type primitif: entier, réels, boolean, char
            //Entiers: byte(1o), short(2o), int(4o), long(8o)
            //Réels: float(4o), double(8o), decimal(16o)
            //Types complexes: (objets, tableaux, string)
            //Booleans: bool
            int myInt; //declaration
            myInt = 10;

            int myInt2 = 20;
            Console.WriteLine("La valeur de ma variable myInt : " + myInt);

            char myChar = 'C';
            bool myBool = true;
            double myDouble = 10.5;
            string str = "test";

            //Mot clé variable: inférence de type - la capacité du compilateur à déterminer le type de la variable en fonction de la valeur qui lui a été affecté
            var maVariable = 10;

            //Opérateur : 
            //Arithmétiques : +, -, *, /, % (modulo: le reste de la division entière)
            int i = 5;

            //Incrémentation et décrémentation ++, --
            i++; //i = i+1
            i--; //i = i-1

            //Opérateur combinés: +=, -=, *=, /=
            i += 5; // i = i + 5

            //Opérateur de comparaison : ==, <, >, >=, <=, !=
            //Opérateur logique: &&, ||, ^(ou exclusif), !(non logique)
            //Table logique
            //A B               A&&B        A||B    A^B         !A ====>  ex : !(VRAIE)= FAUX
            //v v                 v          v       f           f
            //v f                 f          v       v           f
            //f v                 f          v       v           v
            //f f                 f          f       f           v
            int v1 = 10, v2 = 15;
            Console.WriteLine((v2 > v1) || (v1 < v2));
            Console.WriteLine((v2 > v1) ^ (v1 < v2)); //ou exclusif

            //Caractère d'échappement
            Console.WriteLine("\t Bonjour, \nJe suis Dawan. \nFormation C#");

            //Chaine verbatim
            Console.WriteLine(@"    Bonjour,
                                Je suis chez Dawan");

            //Formatage de chaine en utilisant l'interpolation
            int i2 = 15, i3 = 25;
            Console.WriteLine("Mes variables i2 et i3 valent {0} {1}", i2, i3);
            Console.WriteLine("Mes variables " + "i2 = " + i2 + " et " + "i3 = " + i3);

            int ageDuVisiteur; //CamelCase



            #endregion

            #region "Constante"
            //Constante : Variable qui contient une valeur typée qu'on ne peut pas modifier
            const double MA_CONSTANTE = 20.5; //Par convention des constantes est en MAJUSCULES
            Console.WriteLine("Ma constante vaut : " + MA_CONSTANTE);

            #endregion

            #region "Transtypage - Conversion de Types"

            //Conversion implicite : concerne le passage d'un type inférieur à un type supérieur
            //byte -> short -> int(float) -> long -> double ->/long ->
            byte b = 10;
            int myInteger = b;
            int myInteger2 = 30;
            //Cast : Concerne les conversions de types compatibles
            //Conversion explicite: passage d'un type supérieur à un type inférieur
            byte b2 = (byte)myInteger2;

            //Utiliser la classe Convert .... attention ce n'est pas un cas ici
            //On utilise juste la fonction Convert pour convertir le int en byte
            byte b3 = Convert.ToByte(myInteger);

            //cast: il faut que le type qui reçoit la valeur ait la capacité de contenir cette valeur
            int myInteger3 = 260;

            b = (byte)myInteger3;
            Console.WriteLine(b);

            //Erreur de format de la chaine d'entrée est incorrect
            //Impossible de faire la conversion
            /*String str1 = "Dawan";
            int monIntLettre = Convert.ToInt32(str1);
            Console.WriteLine(monIntLettre);*/

            Console.WriteLine("Merci de fournir votre âge : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vous avez " + age + " ans");

            #endregion

            #region "Condition"
            //Expression d'un test conditionnel : Si (condition est vraie) instructions ; Sinon autres instructions
            //if/else
            int nb = 5;
            if (nb > 0)
            {
                Console.WriteLine("nb est positif");
            }
            else
            {
                Console.WriteLine("nb est négatif ou égal à 0");
            }

            //if/else-if/else
            if (nb > 0)
            {
                Console.WriteLine("nb est positif");
            }
            else if (nb == 0)
            {
                Console.WriteLine("nb est égale à 0");
            }
            else
            {
                Console.WriteLine("nb est négatif");
            }

            //Switch: variante if/else-if/else
            int note = 10;
            switch (note)
            {
                case 0:
                    Console.WriteLine("recalé");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("juste la moyenne");
                    break;
                default:
                    Console.WriteLine("réussite garantie");
                    break;
            }
            #endregion

            #region "Boucles"
            //Boucle : répéter un traitement
            //for: connaitre le nombre d'itérations
            //foreach: parcours complet de la collection
            //Boucles conditionnelles : while, do-while

            for (int i5 = 0; i5 < 5; i5++)
            {
                Console.WriteLine("Passage N° : " + i5);
            }

            //Attention aux conditions de sortie d'une boucle afin d'éviter les boucles infinies
            /*for (byte i5 = 0; i5 >= 0; i5++) ;
            {
                Console.WriteLine("passage n° : " + i5);
            }*/

            //foreach : permet de faire un parcours complet du tableau
            int[] tab = { 1, 2, 4, 10, 15 };
            foreach (int item in tab) //pour chaque int se trouve dans tab
            {
                //Attention, la boucle foreach est une boucle en lecture seule
                //Cela veut dire qu'il n'est pas possible de modifier l'élément de l'itération en cours
                /*if(item == 2)
                {
                    item = 45;
                }*/

                Console.WriteLine(item);
            }

            //While
            int x = 1;
            while (x < 5)
            {
                Console.WriteLine("Passage n° : " + x);
                x++; //Si on incrémente pas :(boucle infinie
            }

            do
            {
                Console.WriteLine("PassageDo n° : " + x);
                x++;
            } while (x < 10);

            #endregion

            #region "Tableau"
            //Tableau: ensemble d'éléments typés
            //1 DIMENSION
            //Déclaration d'un tableau en utilisant la taille du tableau
            int[] monTableau = new int[3];
            monTableau[0] = 10;
            monTableau[1] = 15;
            monTableau[2] = 20;

            for (int i6 = 0; i6 < monTableau.Length; i6++)
            {
                Console.WriteLine(monTableau[i6]);
            }

            string str3 = "test";
            string str4 = str3;
            Console.WriteLine(str3);

            //immuable => ne peut pas être modifié une fois crée
            //Cela implique qu'on doit récupérer le résultat dans une nouvelle variable ou le même objet string
            str3 = str3.Replace("t", "T");
            Console.WriteLine("str3 après REPLACE : " + str3);

            //Parcours avec la boucle FOREACH
            foreach (var item in monTableau)
            {
                Console.WriteLine(item);
            }

            //2ème façon de déclarer un tableau (initialisation des valeurs)
            int[] monTableau2 = { 1, 2, 3, 4, 5 };

            //2 dimension
            int[,] matrix = new int[2, 3];
            matrix[0, 0] = 10;
            matrix[0, 1] = 20;
            matrix[0, 2] = 30;
            matrix[1, 0] = 45;
            matrix[1, 1] = 25;
            matrix[1, 2] = 15;

            //2ème façon de déclarer et initaliser un tableau 2D
            int[,] tab2d = { { 10, 20, 30 }, { 45, 25, 158 } };

            //Récupérer le nombre de colonnes
            Console.WriteLine("Nombre de ligne 2D : " + tab2d.GetLength(0));
            //Récupérer le nombre de colonnes
            Console.WriteLine("Nombre de colonne du tableau 2D : " + tab2d.GetLength(1));
            //Récupérer le nombre d'élément dans le tableau
            Console.WriteLine("Nombre total d'éléments du tableau : " + tab2d.Length);

            //Parcours des éléments du tableau 2d
            for (int ligne = 0; ligne < tab2d.GetLength(0); ligne++)
            {
                for (int colonne = 0; colonne < tab2d.GetLength(1); colonne++)
                {
                    Console.WriteLine("[" + ligne + " , " + colonne + "]" + " = " + tab2d[ligne, colonne]);
                }
            }
            #endregion

            #region "Methodes"
            //Visibilités : 
            //- public : accessibilité partout
            //- private : uniquement à l'intérieur de la classe
            //- protected : accessibilité dans la classe et les sous-classes
            //- internal : accès aux classes qui se trouvent dans le même projet (par défaut)

            //Methode : un ensemble d'instructions réutilisable - Permet d'éviter de répéter du code
            //Dans la POO, on a 2 types de methodes :
            //- procédure : une méthode qui ne renvoie aucun résultat (void)
            //- fonctions : une methode qui envoie un résultat
            //Déclarer une methode : visibilité [mot-clé] type-retour nom-méthode (param) {instructions;}

            int somme = MyMethodes.Somme(10, 20);
            Console.WriteLine("Somme = " + somme);
            MyMethodes.Afficher();

            String majuscule = MyMethodes.Majuscule("Je suis en majuscule");
            Console.WriteLine(majuscule);

            int[] tableau = { 10, 0, 20, 15 };
            int somme1 = MyMethodes.Somme(tableau);
            Console.WriteLine("Somme 1 : " + somme1);

            int petit = MyMethodes.MinTableau(tableau);
            Console.WriteLine("L'élément le plus petit du tableau : " + petit);

            double moyenne = MyMethodes.MoyenneTableau(tableau);
            Console.WriteLine("Moyenne = " + moyenne);

            int sommeOptionnel1 = MyMethodes.SommeOptional(10, 20); //C'est le paramètre par défaut du param qui sera pris en compte (c = 10)
            Console.WriteLine(sommeOptionnel1);

            int sommeOptionnel2 = MyMethodes.SommeOptional(10, 20, 40);
            Console.WriteLine(sommeOptionnel2);

            int a1 = 10;
            int b1 = 20;
            Console.WriteLine("Avant permutation : " + "a1 = " + a1 + " - " + "b1 = " + b1);
            MyMethodes.Inverser(ref a1, ref b1);
            Console.WriteLine("Après permutation : " + "a1 = " + a1 + " - " + "b1 = " + b1);

            #endregion

            #region "Dates"
            DateTime dt = new DateTime();
            Console.WriteLine("Datetime: " + dt); //valeur par défaut de DateTime

            DateTime dt1 = DateTime.Now; //Récupère la date d'aujourd'hui
            Console.WriteLine("Datetime: " + dt1);

            DateTime dt2 = DateTime.Today; //Récupère la date sans l'heure
            Console.WriteLine("Datetime: " + dt2);

            var dt3 = new DateTime(2021, 5, 4, 18, 30, 00);
            Console.WriteLine(dt3);

            var dateString = "18/05/1984 17:30:50 PM";
            DateTime dt4 = DateTime.Parse(dateString);
            Console.WriteLine("dt4: " + dt4);

            //Comparaison 
            Console.WriteLine("Comparaison de dt1 et dt2 avec la méthode CompareTo : " + dt1.CompareTo(dt2));
            Console.WriteLine("Comparaison de dt1 et dt2 avec la méthode Equals : " + dt1.Equals(dt2));

            //Opération 
            Console.WriteLine("dt1 + 2 jour : " + dt1.AddDays(2));
            Console.WriteLine("dt1 - dt2 : " + dt1.Subtract(dt2));

            //Recherches
            Console.WriteLine("Date de dt1 : " + dt1.Date);
            Console.WriteLine("Jour du mois de dt1 : " + dt1.Day);
            Console.WriteLine("Jour de la semaine : " + dt1.DayOfWeek);
            Console.WriteLine("Jour de l'année : " + dt1.DayOfYear);

            #endregion

            #region "Enumération"
            //une énum est une liste de valeurs constantes
            //une énumération s'utilise lorsque l'on veut créer un type possédant plusieurs valeurs fixes
            //Comme les jours de la semaine par exemple
            //Permet d'enrichir les types que nous avons déjà à disposition
            Jours j = Jours.LUNDI;
            Console.WriteLine("Valeur du jour : " + j);
            int codeErreur = Convert.ToInt32(Console.ReadLine());
            Erreur erreur = (Erreur)codeErreur;
            Console.WriteLine("Le type d'erreur généré est : " + erreur);

            #endregion

            #region "Concept Objets"
            //Encapsulation - Héritage - Polymorphisme - Abstraction - Agreation (Association - Composition) - Interface

            //Utilisation de l'objet rectangle
            /*double longueur1 = 10;
            double largeur1 = 10;*/

            Rectangle rec = new Rectangle();

            rec.Longueur = 10;
            rec.Largeur = 5;
            double surface = rec.Surface();
            Console.WriteLine("Surface : " + surface);

            Rectangle rec1 = new Rectangle();
            rec1.Longueur = -20;
            rec1.Largeur = 10;
            double surface1 = rec1.Surface();
            Console.WriteLine("Surface : " + surface1);

            Rectangle rec2 = new Rectangle();
            rec2.Longueur = 30;
            rec2.Largeur = 5;
            Console.WriteLine("Obtenir la Largeur avec Mot de passe : " + rec2.Largeur);
            Console.WriteLine("Obtenir la Longueur avec Mot de passe : " + rec2.Longueur);

            CompteBancaire cb = new CompteBancaire();
            cb.Numero = "dse155ed";
            cb.Solde = 1500;
            Console.WriteLine("Constructeur sans paramètre : " + cb.Numero);

            CompteBancaire cb2 = new CompteBancaire("dse155ed", 2000);
            Console.WriteLine("Constructeur avec paramètre : " + cb2);

            CompteBancaire cb3 = new CompteBancaire("dse155ed", 2000);
            Console.WriteLine(cb3);

            //(cb3 == cb2) --> L'opérateur == utilisé entre les objets compare l'adresse des références ici cb2 et cb3
            //cb2 cb3 ne pointent pas sur les mêmes instances(objets)
            //Ce qui implique que l'utilisation de == sur deux instances distinctes sémantiquement équivalent retournera false
            Console.WriteLine("Utilisation de l'opérateur == " + (cb2 == cb3));  //false

            //Pour comparer sémantiquement deux instances on redéfinit la méthode Equals de la classe Object
            Console.WriteLine("utilisation de la methode Equals: " + cb2.Equals(cb3));


            Console.WriteLine(CompteBancaire.NbCompte);

            //Héritage

            Animal animal = new Animal("Boby", 14);
            Console.WriteLine(animal);

            Chat chat = new Chat("minou", 7, "Blanc");
            Console.WriteLine(chat.Couleur);
            chat.Identite();

            Chien chien = new Chien("Bobby2", 7, "Noir");
            Console.WriteLine(chien.Couleur);
            chien.Identite();

            //Polymorphisme
            //Un objet de type Animal peut prendre plusieurs formes - Polymorphisme
            //Le polymorphisme est une conséquence de l'héritage
            //Intérêt : manipuler des objets sans se soucier de leur type
            //La pratique la plus courante du polymorphisme est lorqu'on utilise une classe parente pour référencer une sous-classe, une classe fille

            //Collection polymorphique: ce tableau peut contenir des chats, des chiens, et d'autres animaux
            Animal[] animaux = new Animal[4];
            animaux[0] = new Chat();
            animaux[1] = new Chien();
            animaux[2] = new Chat();
            animaux[3] = new Chien();

            foreach (Animal animal1 in animaux)
            {
                animal1.Identite();
            }

            //Animal animal2 = new Chien();

            //Abstraction
            Personne p = new Homme();
            Personne p2 = new Femme();
            p.Identite();
            p2.Identite();

            //ASSOCIATION: la relation entre deux classes
            //Le fait qu'un objet puisse faire parti des attributs d'un autre objet
            Client client = new Client();
            client.Nom = "NomClient";
            client.Prenom = "PrenomClient";
            //Comme on n'a pas définit les constructeurs dans Adresse on peut initialiser les champs ainsi
            client.Adresse = new Adresse()
            {
                Num = 15,
                Street = "rue de bordeaux 33400"
            };
            Console.WriteLine(client);
            #endregion

            #region "Exception"
            //Une exception est une erreur qui provoque l'arrêt de l'application
            int val = 10;
            int[] tabEntier = { 1, 2 };

            //Dans le bloc try nous isolons le code susceptible de lever une exception
            try
            {
                Console.WriteLine("Division par zéro : " + (val / 0)); //une exception de type DivideByZeroException est levée lorsque le programme atteint cette ligne
                                                                       //Exception permet de capturer tous les types d'exceptions qui seront levées dans le bloc try
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //La clé finally, il permet d'indiquer que dans tous les cas, un code doit être exécuté, qu'une exception intervienne ou pas. Par exemple fermer une connexion à une base de données
            }
            finally
            {
                Console.WriteLine("Bloc finally");
            }

            CompteBancaire cb4 = new CompteBancaire("154feere", 1000);
            try
            {
                cb4.Retrait(1500);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.WriteLine("La suite de l'application");

            #endregion

            #region "La classe string"
            //Les objets de type string sont de type référence et sont surtout immuables : une fois crées en mémoire on ne peut pas le modifier
            //Une chaine est un tableau de caractère
            string monStr = "test";
            //string.Concat(monStr, "e");//Après concatenation, il crée un autre objet en mémoire (dans le heap). Cet objet n'est pas référencé
            //Donc il faut utiliser une variable qui va pointer (récupérer cette objet)
            monStr = string.Concat(monStr, "e");
            Console.WriteLine(monStr);

            //L'opérateur + permet de concaténer des chaines de caractères
            string monStr2 = "test";
            monStr2 = monStr2 + "e";

            string str1 = "teste";
            //Comparaison de contenu d'objet string
            Console.WriteLine("Equal comparaison de contenu " + monStr.Equals(str1));

            //On compare deux objets litteraux, donc ils ont la même référence et le mêle contenu dans le tas (renvoie true)
            //Contrairement à des objets créés dynamiquement avec l'opérateur new dont leur référence sont différentes dans le tas
            //Cat bien que string soit un type référence, les opérateurs d'égalité (==) sont définis pour comparer les valeurs des objets string, pas les références
            //Cela permet de tester l'égalité de chaines de façon intuitive
            //Il existe des methodes pour vérifier la référence de nos objets string : par exemple ReferenceEquals() de la classe Object, vérifie l'égalité des références, cad si deux références pointent vers un objet string similaire
            Console.WriteLine("Avec == comparaison de références sur les instances monStr et str1 " + (monStr == str1));//true

            //Comparaison des références 
            //Car le contenu des chaines est équivalent, mais monStr et str1 ne font pas référence à la même instance de chaine
            Console.WriteLine("Comparaison de référence : " + object.ReferenceEquals(monStr, str1)); //false

            //Quelques : 
            Console.WriteLine(monStr.StartsWith("t"));
            Console.WriteLine(monStr.EndsWith("t"));
            Console.WriteLine(monStr.Length); //Taille = 5
            Console.WriteLine("Premier caractère de monStr " + monStr.ElementAt(0)); //t
            Console.WriteLine("Position du char s dans mon str " + monStr.IndexOf('s'));//2

            //Extraction de sous chaines
            //Substring(a) ==>[a, N[
            //teste
            string sousChaine = monStr.Substring(1);//este
            Console.WriteLine("Sous chaine à partir du premier CHAR : " + sousChaine);
            //substring(a, b) ==> [a, a+b[
            //teste
            string sousChaine2 = monStr.Substring(2, 3);//ste
            Console.WriteLine("Sous chaine à partir du premier CHAR 2 dont la taille est égale à 3 : " + sousChaine2);

            //Chaine sous forme CSVF
            string chaineCSV = "dawan;jehann;paris";
            string[] tabCSV = chaineCSV.Split(';');
            foreach (var item in tabCSV)
            {
                Console.WriteLine(item);
            }

            //Join (inverse de Split)
            string[] names = { "Sara", "David", "Aurore" };
            string namesCSV = string.Join(";", names);
            Console.WriteLine("Resultat de la méthode JOIN : " + namesCSV);

            //Eliminer les espaces de début et de fin de chaine
            string str7 = "  ma chaine ";
            Console.WriteLine("Supression des espaces de debut et de fin de chaine " + str7.Trim());

            Console.WriteLine();
            //Replace
            str7 = str7.Replace("m", "t");
            Console.WriteLine("Ma chaine après REPLACE de m par t " + str7);

            Console.WriteLine(MyMethodes.NombreDeMots(" Je suis un stagiaire de dawan "));//TO DO
            Console.WriteLine(MyMethodes.ChaineInverser("anticonstitutionnellement"));
            Console.WriteLine(MyMethodes.VerifPalindrome("Anna"));

            //Deux façon de construire une chaine (string)
            //Construction implicite en assignant une chaine littéral (entre guillemet)
            string str8 = "ttt";
            string str9 = "ttt";
            string str11 = "t";
            str11 += "tt";

            //Construction explicite en créant un  objet string via l'opérateur new
            string str10 = new string('t', 3);
            string str12 = new string('t', 3);
            char[] tabChar = { 't', 't', 't' };
            string str13 = new string(tabChar);

            Console.WriteLine("str8 == str9 = > " + (str8 == str9)); //true
            Console.WriteLine("str9 == str10 = > " + (str9 == str10)); //true ils ont le même contenu mais pas la même référence
            Console.WriteLine("str8 == str9 = > " + (str10 == str12)); //true ils ont le même contenu mais pas la même référence
            Console.WriteLine("str8 == str9 = > " + (str8 == str9)); //true ils ont le même contenu mais pas la même référence

            Console.WriteLine("Comparaison de référence entre str8 et str9 : " + object.ReferenceEquals(str8, str9)); //true
            Console.WriteLine("Comparaison de référence entre str8 et str9 : " + object.ReferenceEquals(str9, str10));//false
            Console.WriteLine("Comparaison de référence entre str8 et str9 : " + object.ReferenceEquals(str10, str12));//false
            Console.WriteLine("Comparaison de référence entre str8 et str9 : " + object.ReferenceEquals(str8, str11));//false

            //StringBuilder
            //Mutable : une fois créé en mémoire il est possible de changer son contenu
            StringBuilder stb1 = new StringBuilder();
            stb1.Append('_', 10);
            stb1.AppendLine();
            stb1.Append("Mon StringBuilder");
            stb1.Append('-', 10);
            Console.WriteLine(stb1.ToString());

            //chainage d'appel de methodes
            StringBuilder stb2 = new StringBuilder();
            stb2.Append('-', 10).AppendLine("MonStringBuilder").Append('-', 10);
            Console.WriteLine(stb2);

            #endregion

            #region "Collections"
            Console.WriteLine();
            //Collections : ce sont des tableaux dynamiques - leur taille n'est pas fixe
            //2 types de collections
            //Collections faiblement typées : ArrayList, Stack, Queue
            Console.WriteLine("****************************Collections faiblement typées************************");

            //ArrayList
            var myArrayList = new ArrayList();
            Console.WriteLine(myArrayList);
            Console.WriteLine("Taille du tableau: " + myArrayList.Count); //0
            myArrayList.Add(5);
            Console.WriteLine("Taille du tableau après ajout : " + myArrayList.Count); //1
            myArrayList.Add("test");
            Console.WriteLine("Index du chiffre 5 : " + myArrayList.IndexOf(5));//index = 0 (là où se trouve 5)
            myArrayList.Insert(0, 20); //à la position 0 on insère 20
            Console.WriteLine("Index du chiffre 5 après insertion: " + myArrayList.IndexOf(5)); //index = 1

            //boucle for
            for (int i1 = 0; i1 < myArrayList.Count; i1++)
            {
                Console.WriteLine(myArrayList[i1]);
            }

            //Boucle foreach
            foreach (var item in myArrayList)
            {
                Console.WriteLine(item);
            }

            //stack - Pile - LIFO - Last In First Out
            Stack pile = new Stack();
            pile.Push(1);
            pile.Push(2);
            pile.Push("test");
            pile.Push(20.5);
            Console.WriteLine("Nombre d'éléments dans la pile : " + pile.Count);
            Console.WriteLine("La pile contient le chiffre 3 ? " + pile.Contains(20.5));
            pile.Pop(); //Supprie et retourne le dernier élément dans la pile
            Console.WriteLine("La pile contient le chiffre 3 après suppression ? " + pile.Contains(20.5)); //false
            pile.Peek(); //Retourne le dernier élément de la pile sans le supprimer

            //Queue - FIFO - First In First Out
            Queue fifo = new Queue();
            fifo.Enqueue("Dawan");
            fifo.Enqueue(1);
            fifo.Enqueue(100);
            fifo.Enqueue(2.5);
            fifo.Enqueue("Jehann");
            Console.WriteLine("Nombre d'éléments dans la collection : " + fifo.Count);
            Console.WriteLine("La collection contient la chaine Dawan ? " + fifo.Contains("Dawan"));
            fifo.Dequeue(); //Supprime le premier élément insérer dans la liste
            Console.WriteLine("La collection contient la chaine Dawan ? " + fifo.Contains("Dawan"));

            fifo.Clear(); //Suppression de l'ensemble des éléments de la collection 
            Console.WriteLine("Taille de la collection après suppression de tous les éléments : " + fifo.Count); //0

            //Collection FORTEMENT TYPEES
            //List
            List<string> list = new List<string>();
            Console.WriteLine("Taille de la liste : " + list.Count);
            list.Add("Dawan");
            list.Add("Jehann");
            Console.WriteLine("Taille de la liste après ajout d'éléments : " + list.Count);
            Console.WriteLine("Index de Dawan dans la liste " + list.IndexOf("Dawan")); //0
            list.Insert(0, "Test");
            Console.WriteLine("Index de Dawan après insertion " + list.IndexOf("Dawan")); //1
            list.Remove("Dawan");
            Console.WriteLine("La liste contient la chaine de Dawan ? " + list.Contains("Dawan")); //False

            //Boucle for
            for (int i4 = 0; i < list.Count; i4++)
            {
                Console.WriteLine("Avec elementAt " + list.ElementAt(i4));
                Console.WriteLine("Avec crochet tableau " + list[i4]);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Dictionnaire : stockage de type clé : valeur
            Dictionary<int, string> dictionnaire = new Dictionary<int, string>();
            Console.WriteLine("Taille du dictionnaire : " + dictionnaire.Count);

            //Insertion de 10 éléments
            for (int i5 = 0; i5 < 10; i5++)
            {
                dictionnaire.Add(i5, "chaine" + i5);
            }

            Console.WriteLine("Taille du dictionnaire : " + dictionnaire.Count);

            //Liste de valeurs associées avec les clés du dictionnaire
            foreach (var cle in dictionnaire.Keys)
            {
                Console.WriteLine("CLé: {0} - Valeur: {1}", cle, dictionnaire[cle]);
            }
            #endregion

            

            #region "Structure"
            //struct (structure) est un type valeur
            Prod prod1 = new Prod();
            prod1.Id = 1;
            prod1.Nom = "PC Dell";
            prod1.Prix = 2000;

            //On copie la valeur de l'objet
            Prod prod2 = prod1;

            CompteBancaire compte1 = new CompteBancaire();

            //On copie la référence de l'objet
            CompteBancaire compte2 = compte1;

            compte1.Solde = 2500;
            Console.WriteLine("Solde compte 2 " + compte2.Solde);

            prod1.Nom = "Ecran HP";
            Console.WriteLine("Attribut nom du prod2" + prod2.Nom);

            #endregion



            #region "Les fichiers"
            /*
             * .NET fourni des classes qui permettent de manipuler des fichiers
             File et FileInfo : ces 2 classes présentent les mêmes méthodes
            pour la classe File, elles sont statiques - FileInfos elles sont d'instance
            */



            //Créer un répertoire
            Directory.CreateDirectory("monDossier"); //chemin relatif au .exe bin/debug
            //Directory.CreateDirectory("c:\\monDossier"); //chemin absolu (1er solution)
            //Directory.CreateDirectory(@"c:\monDossier"); //Chemin absolu (2ème solution)

            Console.WriteLine("***************Lister les fichiers dans le répertoire***************************");
            //Récupérer les fichiers d'un répertoire
            string[] files = Directory.GetFiles(@"c:\test\");
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            //Récupérer les fichiers d'un répertoire avec l'extension
            string[] pngFiles = Directory.GetFiles(@"c:\test\", "*.png");
            foreach(string png in pngFiles)
            {
                Console.WriteLine("dessin1 : " + png);
            }

            //Récupérer les fichiers d'un répertoire et des sous-répertoire
            Console.WriteLine("*********Fichiers contenus dans un répertoire et ses sous répertoires*********************");
            string[] textFile = Directory.GetFiles(@"c:\test\", "*.txt", SearchOption.AllDirectories);
            foreach(string txt in textFile)
            {
                Console.WriteLine(txt);
            }

            //Suppression des fichiers d'un répertoire
            string[] filesToDelete = Directory.GetFiles(@"c:\test\");
            foreach(string del in filesToDelete)
            {

                File.Delete(del);
            }

            Console.WriteLine();
            //Methode de la classe FileInfos
            FileInfo infos = new FileInfo(@"c:\info\file.txt");
            var dateCreation = infos.CreationTime.ToLongDateString();
            Console.WriteLine("Date de création du fichier file.txt : " + dateCreation);

            //Heure de dernière modification
            var heureModif = infos.LastWriteTime.ToLongTimeString();
            Console.WriteLine("Heure de dernière modif de file.txt : " + heureModif);

            //Dta du dernier accès au fichier 
            var dernierAcces = infos.LastAccessTime.ToLongDateString();
            Console.WriteLine("Date du dernier accès à file.txt : " + dernierAcces);

            //Récupérer l'extension d'un fichier
            var extension = infos.Extension.ToString();
            Console.WriteLine("Extension de file.txt : " + extension);

            //Lecture-écriture de fichier
            //flux(stream): canal intermédiaire entre la source et la destination
            //1 - Charger le fichier dans le flux (lecture/écriture)
            //2 - Execution des opérations (lecture/écriture)
            //3 - Fermeture du flux
            //.NET fourni 2 classes pour la lecture et l'écriture : StreamReader (lecture) - StreamWriter (écriture)
            Console.WriteLine("*************************Lecture d'un fichier***********************");
            StreamReader sr = new StreamReader(@"c:\info\file.txt");
            //Récupération du contenu du fichier
            string contenu = sr.ReadToEnd();
            sr.Close();

            Console.WriteLine("Contenu du fichier file.txt : " + contenu);

            Console.WriteLine("************************Ecriture d'un fichier**************************");
            StreamWriter sw = new StreamWriter(@"c:\info\file2.txt", true);
            //Ecriture dans un fichier
            sw.WriteLine("Ecriture dans un fichier");
            sw.Close();

            try
            {
                Tools.EcritureFichier(@"c:\info\file2.txt", "Test méthode écriture fichier");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            string text = Tools.LectureFichier(@"c:\info\file2.txt");
            Console.WriteLine("Lecture du fichier : \n" + text);

            Console.WriteLine();

            //XmlReader
            using(XmlReader reader = XmlReader.Create(@"c:\info\personne.xml"))
            {
                while (reader.Read())
                {
                    //vérifier s'il y a un élément de départ en utilisant la méthode XmlReader.IsStartElement
                    if(reader.IsStartElement())
                    {
                        switch (reader.Name.ToString())
                        {
                            case "Name":
                                Console.WriteLine("Le nom: " + reader.ReadElementContentAsString());
                                break;
                            case "Age":
                                Console.WriteLine("l'age: " + reader.ReadElementContentAsString());
                                break;
                            case "Adresse":
                                Console.WriteLine("l'adresse : " + reader.ReadElementContentAsString());
                                break;
                            default:
                                break;
                        }
                    }
                }
            }


            //xmlDocument
            XmlDocument xmlDocument = new XmlDocument();

            //Lire le fichier XML
            xmlDocument.Load(@"c:\info\personne.xml");

            //Créer une liste de noeufs xml avec l'extension Path
            XmlNodeList xmlNode = xmlDocument.SelectNodes("/personnes/personne");
            foreach(XmlNode node in xmlNode)
            {
                string name = node["Name"].InnerText;
                string agePersonne = node["Age"].InnerText;
                string adresse = node["Adresse"].InnerText;
                Console.WriteLine("Name: {0} - Age: {1} - Adresse: {2}", name, agePersonne, adresse);
            }

            #endregion


            #region "Sérialisation"
            //Mécanisme qui permet de sauvegarder l'état d'un objet en mémoire dans un fichier
            //3 types de sérialisation possible : binaire - xml -json

            //Mecanisme Binaire
            List<CompteBancaire> listCB = new List<CompteBancaire>();
            listCB.Add(new CompteBancaire("aaaaaa", 1500));
            listCB.Add(new CompteBancaire("bbbbbb", 720000000));
            listCB.Add(new CompteBancaire("cccccc", 800));
            listCB.Add(new CompteBancaire("dddddd", 62000));


            //Export Binaire (écriture)
            Tools.ExportBin(@"c:\info\comptes.bin", listCB);

            //Import Binaire (Lecture)
            try
            {
                List<CompteBancaire> listCB2 = Tools.ImportBin(@"c:\info\comptes.bin");

                foreach (CompteBancaire compteBancaire in listCB2)
                {
                    Console.WriteLine("Lecture du fichier binaire : " + compteBancaire);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            


            Console.WriteLine();
            //Mecanisme XML

            //Export XML (ecriture)
            Tools.ExportXML(@"c:\info\comptes.xml", listCB);

            //Import XML (ecriture)
            try
            {
                List<CompteBancaire> listCB2 = Tools.ImportXML(@"c:\info\comptes.xml");
                foreach(CompteBancaire compteBancaire in listCB2)
                {
                    Console.WriteLine("Lecture du fichier XML : " + compteBancaire);
                }
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Mecanisme JSON
            //Export JSON(ecriture)
            Tools.ExportJSON(@"c:\info\comptes.json", listCB);

            //Import JSON
            try
            {
                List<CompteBancaire> listCB2 = Tools.ImportJSON(@"c:\info\comptes.json");
                foreach(CompteBancaire compteBancaire in listCB2)
                {
                    Console.WriteLine("Lecture du fichier JSON : " + compteBancaire);
                }
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Mécanisme CSV
            //Export CSV
            Tools.ExportCSV(@"c:\info\comptes.csv", listCB);

            //Import CSV
            try
            {
                List<CompteBancaire> compteBancaires = Tools.ImportCSV(@"c:\info\comptes.csv");
                foreach(CompteBancaire compteB in compteBancaires)
                {
                    Console.WriteLine("Lecture du fichier CSV : " + compteB);
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

            #region "Généricité"
            //Le concept de généricité  permet d'exprimer des classes et des méthodes qui sont identiques sur le plan algorithmique mais différent sur la base des types de données
            //Intérêt:
            //  Optimisation du code
            //  Moins de castes à faire - Moins de risque d'erreurs à l'exécution
            MonObjet monObjet = new MonObjet("Chaine de caractères");
            string contenuObj = (string)monObjet.obj; //CAST Obligatoire pour le convertir en string

            ClasseGeneric<string> objGenericString = new ClasseGeneric<string>("Dawan");
            string contenuObjString = objGenericString.data; //Pas besoin de faire un CAST - Aucun risque lié à l'exécution

            ClasseGeneric<int> objGenericEntier = new ClasseGeneric<int>(10);
            int contenuObjEntier = objGenericEntier.data;


            #endregion

            #region "Reflexion - Introspection"
            Console.WriteLine();
            //Reflexion (introspection) : concept qui permet de découvrir ou d'invoquer les membres d'une classe
            //Type: permet de vérifier le type de la classe à découvrir
            //Methodes: 
            //GetFields() : Lister les champs d'une classe
            //GetProperties() : Lister les propriétés d'une classe
            //GetMethodes() : Lister les méthodes d'une classe

            Console.WriteLine("********************Reflexion**************************");
            //Ex : string
            Type typeString = typeof(string);
            Console.WriteLine(typeString.IsClass); //Verifier le type de string (classe, interface...)

            Console.WriteLine("***********************Liste des méthodes de la classe string*************************");
            //Lister les méthodes de la classe string
            MethodInfo[] methodString = typeString.GetMethods();
            foreach(MethodInfo method in methodString)
            {
                Console.WriteLine(method);
            }

            Console.WriteLine("**************************Classe Employe**********************");
            Type typeEmploye = typeof(Employe);
            Console.WriteLine("*************************Liste les propriétés de la classe Employé***********************");
            //Lister les propriétés de la classe Employe
            PropertyInfo[] propEmploye = typeEmploye.GetProperties();
            foreach(PropertyInfo prop in propEmploye)
            {
                Console.WriteLine(prop.Name);
            }

            Console.WriteLine("***********************Lister des méthodes de la classe Employe**********************");
            MethodInfo[] methodEmp = typeEmploye.GetMethods();
            foreach(MethodInfo method in methodEmp)
            {
                Console.WriteLine(method);
            }
            Console.WriteLine();

            //Invoquer les membres d'une classe : Methode (Afficher)
            MethodInfo afficherEmp = typeEmploye.GetMethod("Afficher");

            //Instancier une classe dynamique
            var employe = Assembly.GetExecutingAssembly().CreateInstance("ProjetConsole.Employe", false, BindingFlags.CreateInstance, null, new object[]{ "Pierre ", "Jean "}, null, null);

            Object obj = afficherEmp.Invoke(employe, null);
            Console.WriteLine(obj);
            #endregion

            #region "Interface"

            //Polymorphisme : on manipule des objets sans se soucier de leur type
            IClient c1 = new ClientBddImpl();
            IClient c2 = new ClientImplFichier();
            c1.AjouterClient(new Client());
            c2.AjouterClient(new Client());

            #endregion

            #region "Accès aux données

            //Une application .net utilise le driver (la DDL) ADO.NET pour intéragir avec une BD
            //ADO.NET (Activex Data Object) : un ensemble de classes qui nous permettent d'établir une connexion à la BD'
            //et d'executer des requêtes SQL
            //Pour une BD SQL SERVER le driver est fourni par le framework, pour les autres BD : utiliser NUGET pour télécharger le driver.
            //Mise en place de la couche d'accès aux données:
            //Design pattern (patron de conception):
            //Une solution standart (un ensemble de bonnes pratiques) mise en place par la communauté, dans le but de répondre à des problèmes récurrents

            //DAO: Data Access Object:
            //1- Pour chaque classe définit dans le model objet - créer une table dans la BDD
            //2- Définir une classe dont la seule et unique tâche est d'établir la connexion à la BDD
            //3- Implémenter les Interfaces (définir les classes DAO)

            #endregion

            Console.ReadLine();
        }
        enum Jours
        {
            LUNDI = 1,
            MARDI,
            MERCREDI,
            JEUDI,
            VENDREDI,
            SAMEDI,
            DIMANCHE
        }
        enum Erreur
        {
            MINEURE = 1, MAJEURE, CRITIQUE
        }

        public struct Prod
        {
            public int Id { get; set; }
            public string Nom { get; set; }
            public double Prix { get; set; }

            public Prod(int id, string nom, double prix)
            {
                Id = id;
                Nom = nom;
                Prix = prix;
            }

            public override string ToString()
            {
                return "Nom: " + Nom + " Prix: " + Prix;
            }
        }
    }
}
