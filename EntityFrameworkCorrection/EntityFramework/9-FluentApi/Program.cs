using _9_FluentApi.LinqObject;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_FluentApi
{
    class Program
    {
        public static bool methodeCoure(Course c)
        {
            return c.Description.Contains("c#");
        }

        public static  string methodeCoure2(Course c)
        {
            return c.Description;
        }

       

        // c => c.Description;

        // c => c.Description.Contains("c#")

        //() => instruction
        //(x,y) => instructions
        static void Main(string[] args)
        {
            var context = new MyContext();

            List<Course> courses = context.Courses.Include(c => c.Tags).ToList();

            courses.ForEach(c => Console.WriteLine(c.Description));

            //Par defaut EF utilise un chargement en mode LAZY (tardif) - chargement à la demande
            Console.WriteLine("*******Les tags de chaque cours en mode LAZY - Appel de la méthode Include*********");
            foreach (var cr in courses)
            {
                foreach (var tg in cr.Tags)
                {
                    Console.WriteLine(tg.Name);
                }
            }

            Console.WriteLine("***************************************");

            //LINQ: Langage Integrated Query - langage fournit par Microsoft - qui permet d'interroger différents types
            // de sources de données: bases de données, fichiers..................

            //.net nous propose de façons d'utiliser LINQ
            //Utilisattion de la syntaxe LINQ : adaptée aux dev SQL

            Console.WriteLine("********************LINQ");
            var query = from c in context.Courses
                        where c.Description.Contains("c#")
                        orderby c.Description
                        select c;

            foreach (var item in query)
            {
                Console.WriteLine(item.Description);
            }

            //Utilisation de chainage de méthodes : adaptée à l'utilisation des expressions LAMBDA
            //En programmation objets on a 2 types de méthodes:
            //Fonction: une méthode qui possède un type de retour
            //Procédue: une méthode sans type de retour (void)

            //Expression LAMBDA: une fonction anonyme - qui contient uniquement les params et le corps de la méthode

            Func<int, int> square = x => x * x;
            square(10);

            Action<Course> afficherCours = c => Console.WriteLine(c.Description);

            Func<Course, bool> maFunc = c => c.Price > 10;

            Console.WriteLine("*******************EXPRESSION LAMBDA");
            var query2 = context.Courses
                        .Where(c => c.Description .Contains("c#"))
                         .OrderBy(c => c.Description);

            foreach (var item in query2)
            {
                Console.WriteLine(item.Description);
            }
            //****************************************************SYNTAXE LINQ******************

            Console.WriteLine("*************************SYNTAXED LINQ*********************");

            //Order: lister les cours de l'auteur 2 - les afficher par ordre decroissant (titre)
            var query3 = from c in context.Courses
                        where c.Author.Id == 2
                        orderby c.Title descending
                        select c;

            foreach (var item in query3)
            {
                Console.WriteLine(item.Title);
            }

            //Projection: récupérer les cours de l'auteur 1 - faire une projection (le titre du cours + le nom de l'auteur)

            var query4 = from c in context.Courses
                         where c.Author.Id == 1

                         //Option1: créer une classe qui va contenir les attributs qu'on souhaite projeter
                         select new CourseAuthor { CourseTitle = c.Title, AuthorName = c.Author.Name };
            foreach (var item in query4)
            {
                Console.WriteLine("Title = {0} - Name = {1}", item.CourseTitle, item.AuthorName);
            }

            var query5 = from c in context.Courses
                         where c.Author.Id == 1

                         //Option2: utiliser un objet anonyme
                         select new { CourseTitre = c.Title, NameAuthor = c.Author.Name };

            foreach (var item in query5)
            {
                Console.WriteLine("Title = {0} - Name = {1}", item.CourseTitre, item.NameAuthor);
            }

            //GroupBy: grouper les cours par prix

            var query6 = from c in courses
                         group c by c.Price
                         into g
                         select g; //g contient la liste des groupes
            Console.WriteLine("Liste des groupes de cours par prix");

            foreach (var group in query6)
            {
                //La clé de groupage
                Console.WriteLine(group.Key);
                foreach (var gr in group)
                {
                    Console.WriteLine("\t{0}", gr.Title);
                }

            }

            //Fonctions d'agrégations
            var query7 = from c in context.Courses
                         group c by c.Price
                         into g
                         select g;

            foreach (var group in query7)
            {
                Console.WriteLine("{0} {1}", group.Key, group.Count());
            }

            //Jointure: Inner join, Group join, Cross join

            //Inner join
            Console.WriteLine("**************INNER JOIN");
            var query8 = from c in context.Courses
                         join a in context.Authors on c.AuthorId equals a.Id
                         select new { Title = c.Title, Name = a.Name };

            //Group Join: chaque ligne de gauche avec une ou plusieurs lignes de droite
            var query9 = from a in context.Authors
                         join c in context.Courses on a.Id equals c.AuthorId into g
                         select new { AuthorName = a.Name, NBcourse = g.Count() };

            //Cross Join: chaque ligne de gauche avec chaque de droite
            var query10 = from a in context.Authors
                          from c in context.Courses
                          select new { NameAuthor = a.Name, CourseTitle = c.Title };


            //******************************************************Chainage de méthode
            //Cours dont id = 1
            var cour1 = context.Courses.Where(c => c.Id == 1);
            foreach (var item in cour1)
            {
                Console.WriteLine(item.Title);
            }

            //Projection:(le titre du cours + le nom de l'auteur) pour les cours dont le prix est = 20
            var cour2 = context.Courses.Where(c => c.Price == 20)
                .Select(c => new { CoursTitle = c.Title, AuthorName = c.Author.Name, CoursePrice = c.Price});

            foreach (var item in cour2)
            {
                
                Console.WriteLine("Le titre du cours est {0} et le nom de l'auteur est {1}. Le prix du cours est: {2}", 
                                    item.CoursTitle, item.AuthorName, item.CoursePrice);
                Console.WriteLine("Title = "+item.CoursTitle+" Name= "+item.AuthorName );
            }

            //Chaine verbatim
            string path = @"c:\system\test\test.txt";

            //Projection + OrderBy: la liste des courses prix = 20, order by titre descendant - extraire le titre + le nom de l'auteur
            var cour3 = context.Courses
                        .Where(c => c.Price == 20)
                        .OrderByDescending(c => c.Title)
                        .Select(c => new { Titre =c.Title, Name = c.Author.Name });

            foreach (var item in cour3)
            {
                Console.WriteLine($"{item.Titre} {item.Name}");
            }

            //GroupBy
            var groups = context.Courses
                         .GroupBy(c => c.Price);

            foreach (var item in groups)
            {
                //Afficher le groupe
                Console.WriteLine(item.Key);
                foreach (var g in item)
                {
                    Console.WriteLine(g.Title);
                }
            }

            //Join: le titre des cours + le nom de l'auteur 1

            var join = context.Courses
                       .Join(context.Authors,
                       c => c.AuthorId,
                       a => a.Id,
                       (course, author) => new { authorName = author.Name, courseTitle = course.Title });

            //Suppression en cascade
            //Supprimer les cours de l'Auteur 1

            Console.WriteLine("*************Suppression des cours de l'auteur 4");
            //var auth4 = context.Authors.Include(a => a.Courses).Single(a => a.Id == 4);

            //Suppression des cours de l'Auteur 4
            // context.Courses.RemoveRange(auth4.Courses);

            //Supprimer Auteur 5

            //Suppression en cascade = false - la suppression d'un Auteur n'implique la suppression des cours
            //Solution: supprimer les cours de l'Auteur 5 ensuite supprimer l'auteur en question


            /* var auth5 = context.Authors.Include(a => a.Courses).Single(a => a.Id == 5);
             context.Courses.RemoveRange(auth5.Courses);

             context.Authors.Remove(auth5); 

             Console.WriteLine("Auteur 5 supprimé de la BD......................");*/

            //Suppression du TAG 2 - CascadeDelete = true
            var tag2 = context.Tags.Find(2);
            context.Tags.Remove(tag2);
            


            context.SaveChanges();

            Console.WriteLine("Tag2 supprimé de la BD...................");

            Console.ReadKey();
        }
    }
}
