using ProjetDLL.Agregation.association;
using ProjetDLL.Agregation.faible;
using ProjetDLL.Agregation.forte;
using ProjetDLL.Comparateur;
using ProjetDLL.Delegates;
using ProjetDLL.DesignPattern.Comportement.ChainOfResponsability;
using ProjetDLL.DesignPattern.Comportement.Iterators;
using ProjetDLL.DesignPattern.Comportement.Memento;
using ProjetDLL.DesignPattern.Comportement.Observer;
using ProjetDLL.DesignPattern.Creation.Builder;
using ProjetDLL.DesignPattern.Creation.Factory;
using ProjetDLL.DesignPattern.Creation.Prototype;
using ProjetDLL.DesignPattern.Creation.Singleton;
using ProjetDLL.DesignPattern.Structure.Adapter;
using ProjetDLL.DesignPattern.Structure.Proxy;
using ProjetDLL.Encapsulation;
using ProjetDLL.ExoQuiz;
using ProjetDLL.ExpressionLambda;
using ProjetDLL.Generic;
using ProjetDLL.Polymorphisme;
using ProjetDLL.SOLID.DependecyInjection.Good;
using ProjetDLL.SOLID.LiskovSubstitution.Bad;
using ProjetDLL.SOLID.LiskovSubstitution.Good;
using ProjetDLL.SOLID.LiskovSubstitution.Good2;
using ProjetDLL.SOLID.OpenClose.Good;
using ProjetDLL.SOLID.SingleResponsability.Good;
using ProjetDLL.TypeDynamic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static ProjetDLL.Delegates.MyDelegate;
using static ProjetDLL.DesignPattern.Comportement.ChainOfResponsability.ComplaintRequest;

namespace ProjetConsole
{
    class Program
    {
        //ressource
        static int total = 0;

        //Verrou
        static object _lock = new object();

        static void Main(string[] args)
        {
            #region "Type Dynamic"
            /*
             * Depuis la version 4.5 de .net un nouveau type de données appelé Dynamic à été ajouté au framework: 
             * Le type de données est vérifié à l'execution
             */

            Console.WriteLine("***********************TYPE DYNAMIC");

            dynamic myDynamic = 10;
            Console.WriteLine("Type de ma variable: " + myDynamic.GetType()); // System.int32

            myDynamic = "test"; //sans faire de Cast
            Console.WriteLine("Type de ma variable: " + myDynamic.GetType()); // String

            Console.WriteLine(DynamicClass.Addition(10, 20)); //30

            string st1 = "Hello ";
            string st2 = "world ";

            Console.WriteLine(DynamicClass.Addition(st1, st2)); // Hello world

            #endregion

            #region "GENERIC"

            //Permet de définir des classes et des méthodes génériques - dans le but d'optimiser le code

            Console.WriteLine("************************GENERIC");

            //Classe GENERIQUE
            MyClassGeneric<int> classGen = new MyClassGeneric<int>();
            classGen.A = 10;
            classGen.B = 15;
            classGen.Permuter();
            Console.WriteLine("Après permutation: " + classGen.A + " " + classGen.B);

            MyClassGeneric<string> classGen2 = new MyClassGeneric<string>();
            classGen2.A = "Dawan";
            classGen2.B = "Jehan";
            classGen2.Permuter();
            Console.WriteLine("Après permutation: " + classGen2.A + " " + classGen2.B);

            //METHODE GENERIQUE
            Produit p = new Produit() { Id = 1, Description = "pc dell", Prix = 1200 };
            string jsonResult = Tools.ToJson<Produit>(p);
            Console.WriteLine(jsonResult);

            #endregion

            #region "Reflexion - Introspection"

            //Concept qui permet de lister les membres (propriétés - méthodes) d'une classe données
            //3 méthodes à utiliser:
            //GetType - GetMethods - GetProperties

            //Lister les méthodes de la classe string

            Type typeStr = typeof(string);
            MethodInfo[] methods = typeStr.GetMethods();

            foreach (MethodInfo m in methods)
            {
                Console.WriteLine(m.Name);
            }

            Console.WriteLine("**********************Reflexion");

            //Lister les memebres de la classe Employe
            Type employeType = typeof(Employe);

            //Les propriétés de la classe Employe
            PropertyInfo[] props = employeType.GetProperties();

            Console.WriteLine("Property de Employe:");
            foreach (PropertyInfo prop in props)
            {
                Console.WriteLine(prop.Name);
            }

            //Les méthodes défnies dans la classe Employe
            MethodInfo[] methodes = employeType.GetMethods();

            Console.WriteLine("Méthodes de Employe:");

            foreach (MethodInfo mt in methodes)
            {
                Console.WriteLine(mt.Name);
            }

            //Appel de la méthode Afficher de la classe Employe

            Console.WriteLine("Appel de la mathode Afficher:");

            MethodInfo afficher = employeType.GetMethod("Afficher");
            if (afficher.IsStatic)
                Console.WriteLine("Méthode static");
            else
                Console.WriteLine("Méthode d'instance");

            if (afficher.IsPublic)
            {
                Console.WriteLine("Méthode public");

            }

            else
            {
                Console.WriteLine("Méthode Private");
            }

            //Instancier la classe Employe
            Employe emp = (Employe)Activator.CreateInstance(employeType, null); //Appel du constructeur sans param
            Console.WriteLine("Constructeur sans parama: " + emp);

            Employe emp1 = (Employe)Activator.CreateInstance(employeType, new object[] { "Dawan", "Jehann" });
            Console.WriteLine("Constructeur avec params: " + emp1);

            //Appel de la méthode Afficher
            afficher.Invoke(emp, new object[] { "MACRON", "Emmanuel" });

            #endregion

            #region "Delegate"

            //Signature d'une méthode: visibilité [static] type_retour (void) nom_methode(param(type simple - complexe) - méthode(Delegate))
            //Delegate: un object (pointeur) qui ponite vers une méthode
            //Intérêt: permet de rendre les applications facilement extensible
            Console.WriteLine("*********************DELEGATE");
            MyDelegate.Somme(10, 20);
            MyDelegate.Soustraction(15, 5);

            //Utilisation du Delegate pour ajouter des fonctionnalités
            Operation Multiplication = new Operation(Multip);

            Multiplication(10, 15);

            Operation Division = new Operation(Divis);

            Division(10, 2);

            //.net propose des Delegate qu'on peut utiliser
            //Pour les méthodes avec un type de retour Func

            Func<int, int, int> Mulplication2 = Multip;
            Mulplication2(10, 5);

            //Pour les méthode sans type de retour Action
            Action<Employe> afficherEmployer2 = AfficherEmployer;

            //Pour les méthodes qui renvoie un boolean Predicat
            Predicate<Employe> predicat = (employe) => employe.Nom.Contains("Da");

            Func<int, int> carre = (n) => n * n;
            Action<Employe> empConsole = (employe2) => Console.WriteLine(employe2);

            List<Employe> lst = new List<Employe>();
            lst.Add(new Employe("Dawan", "Jehann"));
            lst.Add(new Employe("Paris", "Bordeaux"));
            lst.Add(new Employe("Macron", "Emmanuel"));

            //c# v2: 

            lst.Find(delegate (Employe emp4) { return emp4.Nom.Equals("Dawan"); });

            //c# v3: introduction des expressions lambda

            lst.Find((emp5) => emp5.Nom.Equals("Dawan"));

            Helper.modifList(lst, ls =>
            {
                ls.ForEach(empl => { empl.Nom.ToUpper(); });
                return ls;
            });

            Helper.modifList(lst, 
                ls => 
                { 
                    ls.Add(new Employe("new", "new")); 
                    return lst;
                });

            Helper.modifList(lst, maMethode);

            //Méthodes d'extension
            string chaine = "Dawan";
          
            

            chaine = MyTool.changeFirstChar(chaine);
            Console.WriteLine(chaine);



            #endregion

            #region "Expression Lambda"

            //Une méthode anonyme : syntaxe qui permet d'exprimer des méthodes

            List<Book> books = new List<Book>();
            books.Add(new Book() { Title = "book1", Price = 5 });
            books.Add(new Book() { Title = "book2", Price = 17 });
            books.Add(new Book() { Title = "book3", Price = 7 });

            //les livres dont le price < 10
            var books10 = books.FindAll(b => b.Price < 10);

            books10.ForEach(b => Console.WriteLine(b.Title));

            //Trier la liste books

            //Option1: imlémenter IComparable dans la classe Book
            books.Sort(); //attends l'implémentation de l'interface IComparable

            Console.WriteLine("Books après appel de Sort");
            books.ForEach(b => Console.WriteLine(b.Title));

            //Option2: définir des comparateurs (classes qui implémentent l'interface IComparer)

            //Tri par prix croissant
            Console.WriteLine("Tri par prix croissant:");
            books.Sort(new BookPrixCroissant());

            books.ForEach(b => Console.WriteLine(b.Title));

            //Tri par prix décroissant
            Console.WriteLine("Tri par prix décroissant:");
            books.Sort(new BookPrixDecroissant());
            books.ForEach(b => Console.WriteLine(b.Title));


            #endregion

            #region "Processus"

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(  "***************************Process");

            //Processus: um programme en cours d'exécution
            //.net fournit une classe qui nous de gérer les processus du poste local

            var processes = Process.GetProcessesByName("chrome");

            foreach (var proc in processes)
            {                           //octets           //bit   //meg octets
                Console.WriteLine(proc.PagedMemorySize64 / 1024 / 1024);
            }

            //foreach (var proc in processes)
            //{
            //    proc.Kill();
            //}

            //voir projet winform
            #endregion

            #region "Thread"

            //Thread: une tâche en cours d'exécution

            //Une application par defaut possède qu'un seul thread - ne peut executer qu'une seule tâche à la fois

            Console.WriteLine("*********************THREADS");

            Thread t1 = new Thread(
                () =>
                {
                    Console.WriteLine("Thread1 lancé........");
                    Thread.Sleep(10000);
                }
                );
            Thread t2 = new Thread(() => Console.WriteLine("Thread2 lancé........"));

            t1.Start();

            t1.Join(3000);
            t2.Start();
            t2.Join();

            //Admin user OK

            //Suspendre le thead principal : le mettre en attente de t1 et t2 on utilise la méthode Join()

            Console.WriteLine("Thread principal...................");


            //Accès à une ressource partagée: gestion de l'accès conccurentiel à une ressource

            Console.WriteLine("Accès à une ressource partagée en multithread");

            Thread th1 = new Thread(AddMillion);
            Thread th2 = new Thread(AddMillion);
            Thread th3 = new Thread(AddMillion);

            th1.Start();
            th2.Start();
            th3.Start();

            th1.Join();
           th2.Join();
           th3.Join();

            Console.WriteLine("Total= " + total);

            Console.WriteLine("Avantages du Multithreading:");

            Console.WriteLine("PC avec un Thread:");
            Stopwatch watch = Stopwatch.StartNew();

            Somme1();
            Somme2();

            watch.Stop();
            Console.WriteLine("Temps d'execution avec 1 seul Thread: " + watch.ElapsedMilliseconds);


            Console.WriteLine("PC avec 2 Thread:");

            watch = Stopwatch.StartNew();

            Thread thread1 = new Thread(Somme1); 
            Thread thread2 = new Thread(Somme2);

            thread1.Start();
            thread2.Start();

            watch.Stop();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("Temps d'execution avec 2 Threads: " + watch.ElapsedMilliseconds);

            Console.WriteLine("Nombres de processeurs : " +Environment.ProcessorCount);

            //Le multithreading nous permet d'obtenir des applications responsives - un gain conséquent en terme de temps
            //d'éxecution

            //voir projet winform
            #endregion

            #region "Programmation Asynchrone"
            /*Un programme c# s'éxecute par defaut de manière synchrone:
             * 
             * instruction1;
             * Afficher();
             * instruction2; - attends la fin de l'execution la méthode afficher()
             * 
             * Un programme asynchrone:
             * instruction1;
             *  Async Afficher(); Async demande au compilateur d'executer la méthode Afficher dans un thread isolé
             * instruction2; n'a pas besoin d'attendre la fin de l'execution de afficher
             * instruction3 : depends de Afficher() - await Afficher()
             * 
             * Task: opération en cours d'execution - c'est un objet qui représente une méthode en cours d'execution
             * Pour une méthode avec un type de retour : Task<int>
             * 
             * Approche Asynchrone: nous permet de rendre les applications responsives
             * 
             * voir projet Asynchrone.Winform
             */
            #endregion

            #region "Concepts objets"

            //Encapsulation: l'accès aux membres d'une classe doit forcément passer par Get/Setter

            ProjetDLL.Encapsulation.Rectangle rec = new ProjetDLL.Encapsulation.Rectangle(20, 10);

            //voir encapsulation dans projetdll

            //Le seul moyen de modifier les attributs du rec est de faire appel à la méthode Redim
            rec.Redim(10, 10);

            //Polymorphisme
            PolyTest.Buy(10);
            PolyTest.Buy("test");
            PolyTest.Buy(true);
            PolyTest.Buy(new Table());

            IPliable pliable = new Table();

            PolyTest.Buy2(new Table());
            PolyTest.Buy2(new Chaise());

            //voir polymorphisme dans projet dll

            //Agrégation

            //Faible
            Salarie s = new Salarie("nom", "prenom", new Adresse() { Num = 1, Street = "rue de paris 75010 Paris" });
            Salarie s2 = new Salarie("nom1", "prenom1", null);

            //Forte

            Voiture v = new Voiture(new Moteur("Diesel"));

            //Association d'objet: le fait qu'un objet utilise d'autres objets de manière temporaire
            v.Garer(new Parking());

            #endregion

            #region "Exo QUIZ"
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("******************Test exo quizz*************");

            QuizTest quizTest = new QuizTest(DateTime.Now, QuizDAO.QuizExemple(), new Utilisateur("dawan", "mmahrane@dawan.fr"), 0);

            //Pour chaque question
            foreach (QuizQuestion question in quizTest.Quizz.Questions)
            {
                //Afficher la question 
                Console.WriteLine(question.QstText);

                //Afficher les réponses possibles 
                int i = 1;
                foreach (QuizReponse reponse in question.Reponses)
                {
                    Console.WriteLine($"{i} - {reponse.RepText}");
                    i++;
                }

                //Demander à l'utilisateur son choix
                bool erreur = false;

                do
                {
                    try
                    {
                        Console.WriteLine("Votre choix ?");

                        //lire le choix saisi et vérifier si la réponse est correcte
                        string choiceStr = Console.ReadLine();
                        quizTest.CheckReponse(question, choiceStr);
                        erreur = false;
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Erreur: " +ex.Message);
                        erreur = true;
                    }

                } while (erreur);
            }//fin de la boucle des questions

            Console.WriteLine("VOTRE SCORE: "+quizTest.Score);

            //Envoyer le résultat par Email
            //quizTest.EnvoyerResultat();

            #endregion

            #region "Loi DEMETER"
            /*Lorsqu'on crée des classes on ne fait pas toujours attention aux dépendences
             * - une classe peut utiliser d'autres classes, soit par agrégation, soit par passages des params par méthodes
             * 
             * - une classe A utilise une classe B
             * - une méthode de B utilise une classe C
             * - La classe A va donc utliser la classe C
             * 
             * ** Loi Demeter
             * - chaque classe doit avoir une connaissance limitée des autres classes
             * ---  Une classe ne doit parler qu'à ses classes amies.
             * 
             * En pratique:
             * Une méthode d'une classe peut invoquer les méthodes:
             * - de l'objet
             * - des paramètres de la méthode
             * - des objets crées dans la méthode
             * - des propriétés ou des champs de l'objet
             * 
             * voir Demeter dans projet DLL
             */
            #endregion

            #region "Tell don't ask"

            //Dites, ne demander pas: dites à vos objets ce qu'ils doivent faire, ne leur posez pas de questions sur leur état

            #endregion

            #region "Les principes SOLID"

            /*SOLID est l'acronyme de:
             * S: Single of Responsability
             * O: Open/Close
             * L: Liskov Substitution
             * i: Interface Segregation
             * D: Dependency Injection
             * 
             * Ce sont de bonnes pratiques à appliquer dans la conception objets.
             * 
             * N'importe qui peut écrire un code qu'une machine. Un bon dev c'est quelqu'un qui ecrit un code qu'un être
             * humain peut comprendre.
             * 
             * Noms: classes, méthodes et variables
             * 
             * public void CheckProfilUser(User u)
             * {
             *
                    if(isUserAdmin(u))
                        admin.html
                    else
                        return view();
             * }
             * 
             * public bool IsUserAdmin(User u)
             * return u.isAdmin();
             * 
             * public class User{
             * property bool isAdmin;
             * 
             * public bool isAdmin(){
             *  return isAdmin;
             * }
             * 
             * }
             * 
             * Intérêt:
             * permettent d'améliorer la cohésion, de diminuer le couplage et de favoriser l'encapsulation d'un programme objet.
             * 
             * Cohésion:
             * un module (classe ou ensemble de classe) est dit cohésif s'il ne fait qu'une seule et unique tâche précise.
             * 
             * Couplage:
             *  2 modules (2 classes) sont dits couplés si la modification d'un module implique la modif du second
             *  
             * Encapsulation:
             * Un objet devrait masquer au maximum sa structure interne.
             */

            Console.WriteLine("******************SINGLE OF RESPONSABILITY**************");

            //Définir des classes responsables d'une seule et unique tâche par conséquent une classe ne doit avoir qu'une seule
            //raison de changer

            //Avantages:
            //code très lisible - facile à maintenir
            ContactDAO dao = new ContactDAO();

            try
            {
                dao.Save(new ProjetDLL.SOLID.SingleResponsability.Good.Contact());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }

            //voir dossier SingleResponsabilty dans DLL

            Console.WriteLine("****************OPEN/CLOSE*************");

            //une classe doit restée ouverte à l'extension mais fermée à la modification

            //Rectangles rectangle = new Rectangles() { Hauteur = 10, Largeur = 20 };
            //SurfaceCalculateur.Surface(rectangle);

            //Cercle cercle = new Cercle() { Rayon = 15 };
            //SurfaceCalculateur.Surface(cercle);

            ////Ajout de la classe Traingle - pas besoin de modifier la classe SurfaceCalculateur
            //Triangle triangle = new Triangle() { Base = 10, Hauteur = 15 };
            //SurfaceCalculateur.Surface(triangle);

            //Sphere sphere = new Sphere() { Rayon = 20 };
            //SurfaceCalculateur.Surface(sphere);


            Console.WriteLine("**************LISKOV SUBSTITUTION*****************");
            //Les sous-types doivent ^étre subtituables à leur type de base

            //Dans un code, remplacer un objet parent par un objet enfant; ne doit pas impliquer la modification du comportement du code
            //Un objet enfant doit se comporter comme un objet parent

            Vehicule vehicule = new Vehicule();

            Voitures voiture = new Voitures();
            


            //Utilisation de l'objet parent - Est ce que l'objet enfant peut remplacer l'objet parent, sans modifier le comportement du code?
            vehicule.Demarrer();
            voiture.Vidange();

            //Good
            Vehicules v2 = new Vehicules();
            Voituress voiture2 = new Voituress();

            voiture2.Demarrer(); //Vehicule démmaré.....

            voiture2.DemarrerVoiture();

            voiture2.DemarrerVoiture("golf");

            Parent parent = new Parent();

            Enfant enfant = new Enfant();
            Console.WriteLine(enfant.getPassword());
            Console.WriteLine(enfant.getUser());

            //Solution: les classent enfants doivent garder l'implementation des méthodes des classes parentes

            Console.WriteLine("****************Interface Segregation (Séparation d'interface)************");
            //voir projet DLL

            Console.WriteLine("*****************Dependency Injection*****************************");


            //Injection par setteur
            UserService service = new UserService();
            service.Repo = new UserRepository();
            service.TraiterUser(1);

            service.Repo = new UserRepositorySQL();
            service.TraiterUser(1);

            service.Repo = new UserRepositoryOracle();

            UserService service2 = new UserService(new UserRepository());
            service2.TraiterUser(2);

            UserService service3 = new UserService(new UserRepositorySQL());
            service3.TraiterUser(3);

            UserService service4 = new UserService(new UserRepositoryOracle());
            service4.TraiterUser(5);

            //injection via Setteur
            UserService service6 = new UserService();
            service6.Repo = new UserRepositorySQL();
            UserController Controller = new UserController(service6);

            //Injection via contructeur
            Console.WriteLine("Choisir base de données: tapez SQL ou ORACLE");
            string choix = Console.ReadLine();

            UserController controller2 = null;

            if (choix.Equals("SQL"))
            {
                controller2 = new UserController(new UserService(new UserRepositorySQL()));
            }
            else
            {
                controller2 = new UserController(new UserService(new UserRepositoryOracle()));
            }

            
            controller2.UserManager(1);

            UserController control = new UserController(new UserService(new UserRepositorySQL()));
            UserController control2 = new UserController(new UserServiceSQL(new UserRepositorySQL()));

            #endregion

            #region "Design Pattern"

            //Design Pattern: solution classique à des problèmes de conception objet réccurrents.
            //GOF: Gang Of Four - 4 auteurs qui ont écrit un livre qui détail les différents pattern
            /*
             * Patters de création: singleton, Builder, Fatory, Prototyê
             * 
             * Patterns de comprtement (Behavior): Proxy, observer, Adapter, State, Memento, Chain Of Responsability..
             * 
             * Patterns de structure: Mediator, Visitor, Iterator, Strategy, Command
             * 
             */
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*************************DESIGN PATTENR********************************");

            Console.WriteLine("*********************PATTERNS DE CREATION");

            Console.WriteLine("**************SINGLETON");
            //Problème: garantir l'existence d'une et unique instance d'une classe donnée dans l'application

            Directeur directeur = Directeur.Instance;
            directeur.Name = "Dawan";

            Directeur directeur2 = Directeur.Instance;
            directeur2.Name = "Jehann";


            Directeur directeur3 = Directeur.Instance;
            directeur2.Name = "Paris";

            Console.WriteLine("Directeur1: "+directeur.Name);
            Console.WriteLine("Directeur2: "+directeur2.Name);
            Console.WriteLine("Directeur3: "+directeur3.Name);

            Console.WriteLine("******************FACTORY");
            //Avoir une classe qui gère la création d'objet - Une fabrique d'objet

            IShape rectangle1 = ShapeFactory.CreateShape("rectangle");
            IShape cercle1 = ShapeFactory.CreateShape("cercle");

            IShape rectangle2 = ShapeFactory.CreateShape<IShape>(typeof(ProjetDLL.DesignPattern.Creation.Factory.Rectangle), null);
            IShape triangle1 = ShapeFactory.CreateShape<IShape>(typeof(ProjetDLL.DesignPattern.Creation.Factory.Triangle), new object[] { 15, 20} );

            ShapeFactory.SommeNumbers(1, 2);
            ShapeFactory.SommeNumbers(1, 2, 3);
            ShapeFactory.SommeNumbers(1, 2, 3, 4);

            Console.WriteLine("******************BUILDER");
            //Pour des classes complèxe - une classe qui gère la création d'objets de cette classe

            BankAccount account = new BankAccountBuilder()
                                  .withNumber(12345)
                                  .withNameAndPassword("name", "password")
                                  .Build();

            BankAccount account2 = new BankAccountBuilder()
                                  .withNumber(12345555)
                                  .withNameAndPassword("name1", "password1")
                                  .withLoad(10000, 2.5f)
                                  .accountIsLoanInsured(true)
                                  .AccountIsLocker(false)
                                  .Build();

            Console.WriteLine("******************PROTOTYPE");

            //Créer des copies d'objets à partir d'autres objets existants sans rendre le code dépendant des attributs de leur classe
            //Une copie d'un objet A sans B.name = A.name

            //Copie d'un objet simple
            Console.WriteLine("Copie d'un objet simple");

            LineArticle art1 = new LineArticle() { Description = "PC DELL", Price = 1200 };
            LineArticle art2 = (LineArticle)art1.Clone();

            //Console.WriteLine(art2);

            art1.Description = "ECRAN HP";
            Console.WriteLine("art1: "+art1);
            Console.WriteLine("art2: "+art2);

            //Copie d'un objet complèxe

            Console.WriteLine("Copie d'un objet complèxe");


            CartLine cartLine1 = new CartLine() { Article = art1, Qty = 5 }; //Ecran HP
            CartLine cartLine2 = (CartLine)cartLine1.Clone(); //Ecran HP

            Console.WriteLine("cartLine2 avant modif de cartLine1: "+cartLine2); //Ecran HP

            cartLine1.Article.Description = "Souris";
            //cartLine2 = (CartLine)cartLine1.Clone();

            Console.WriteLine("cartLine1: "+cartLine1);
            Console.WriteLine("cartLine2 après modif de cartLine1: "+cartLine2);

            //copien plus comlèxe
            Cart cart = new Cart();
            cart.Lines = new List<CartLine>() { cartLine1, cartLine2 };

            cart.Clone();

            //Implémenter l'interface IClonable - cloner les membres complèxes de manière explicite qu'une classe peut contenir

            Console.WriteLine("*********************PATTERNS DE COMPORTEMENT********************");

            Console.WriteLine("***********************MEMENTO");
            //Problème: pouvoir restaurer l'état précedent d'un objet
            //Ex: editeur de texte
            /*
             * a
             * b
             * c
             * undo
             */
            Editeur editeur = new Editeur();
            var history = new History();

            editeur.Content = "a";
            history.Push(editeur.CreateState());

            editeur.Content = "b";
            history.Push(editeur.CreateState());

            editeur.Content = "c";

            Console.WriteLine("Etat actuel: "+editeur.Content); // c
            editeur.Restore(history.Pop());

            Console.WriteLine("Etat après une première restauration:  "+editeur.Content); //b

            editeur.Restore(history.Pop());
            Console.WriteLine("Etat après une deuxième restauration:  " + editeur.Content); //a

            Console.WriteLine("***********************OBSERVER");
            //Objectif: permet de mettre en place un mécanisme de souscription pour envoyer des notifications
            //à plusieurs objets au sujet d'un évenement concernant les objets qu'ils observent

            ProductItem product = new ProductItem() { Description = "PC DELL", Price = 1200 };
            product.Attach(new Customer("dawan", "adresse email"));

            product.Price = 900; //ce changement de prix déclenche une notification par Email

            Console.WriteLine("***********************ITERATOR");
            //Objectif: parcourir une collection d'objets sans fournir d'infos sur le type de collection

            var navigateur = new BrowserHistory();
            navigateur.Push("google.fr");
            navigateur.Push("dawan.fr");
            navigateur.Push("gmail.fr");

            foreach (var url in navigateur.Urls)
            {
                Console.WriteLine(url);
            }

           
            //problème: on voit bien qu'il s'agit d'une collection de List<string>

            Console.WriteLine("Parcours avec un Iterator");
            Iterator iterator = navigateur.CreateIterator();

            while (iterator.hasNext())
            {
                var url = iterator.Current();
                Console.WriteLine(url);
                iterator.Next();
            }

            Console.WriteLine("***********************CHAIN OF RESPONSABILITY");
            //Objectif: permet de faire circuler des demandes dans une chaine de handler (objets pouvant traiter la demande)
            //Lorsqu'un handler reçoit une demande, il peut soit la traiter soit l'envoyer au handler suivant dans la chaine
            //Chaque membre de la chaine possède un membre supérieur et peut traiter la demande.

            StaffMember prof = new Teacher("prof", new DirectPedago("DirectPedago", new Directeurs("Directeur", null)));

            Console.WriteLine("----Req1--------------");
            prof.handleComplaint(new ComplaintRequest(130, 1, "req1", ComplaintState.OPENED)); //prof

            Console.WriteLine("---Req2---------");
            prof.handleComplaint(new ComplaintRequest(250, 2, "req2", ComplaintState.OPENED)); //Pedago

            Console.WriteLine("---Req3---------"); 
            prof.handleComplaint(new ComplaintRequest(320, 3, "req3", ComplaintState.OPENED)); //Directeur

            Console.WriteLine("*********************PATTERNS DE STRUCTURE********************");

            Console.WriteLine("****************PROXY");
            //Objectif: permet d'utiliser un substitu pour un objet. Donne le contrôle sur l'objet original
            //nous permettant d'effectuer des manipulations avant ou après que la demande lui parvienne
            //L'objet original passe par un proxy
            //Ex: message transmis par un user

            IMessages finalMessage = new MessageProxy(new UserMessage("test de proxy"));
            Console.WriteLine(finalMessage.getContent());

            Console.WriteLine("****************ADAPTER");

            //Permet de faire collaborer des objets ayant des interfaces normalement incompatibles.
            //Conversion d'interfaces

            //ex: Interfcae qui renvoie du contenu xml - fournir une interface pour adapter le contenu en json

            IJsonAdapter adapter = new JsonAdapter(new ContactRepository());
            string jsonContent = adapter.FindJsonContacts("contacts.xml");

            Console.WriteLine(jsonContent);


            #endregion





            Console.ReadLine();
        }

        public static int Multip(int x, int y)
        {
            return x * y;
        }
        public static int Divis(int x, int y)
        {
            return x / y;
        }

        public static void AfficherEmployer(Employe emp)
        {
            Console.WriteLine(emp);
        }

        public static bool Verifier(Employe emp)
        {
            return emp.Nom.Contains("Da");
        }
        //(Employe emp) => emp.Nom.Contains("Da")


        public static List<Employe> maMethode(List<Employe> lst)
        {
            List<Employe> ls = new List<Employe>();

            lst.Add(new Employe());
            ls = lst;

            return ls;
        }

        public static void AddMillion()
        {
            for (int i = 0; i < 1000000; i++)
            {
                //Vérouiller la ressource
                lock (_lock)
                {
                    total++;
                }
                
            }
        }

        public static void Somme1()
        {
            int sum = 0;
            for (int i = 0; i < 50000000; i++)
            {
                sum += i;
            }
            Console.WriteLine("Somme1 = " + sum);
        }

        public static void Somme2()
        {
            int sum = 0;
            for (int i = 0; i < 50000000; i++)
            {
                sum += i;
            }
            Console.WriteLine("Somme2 = " + sum);
        }

    }
}
