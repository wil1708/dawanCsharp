using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DbFirstDetail
{
    class Program
    {
       
        static void Main(string[] args)
        {
            PlutoEntities2 context = new PlutoEntities2();

            Courses c = new Courses();
            c.FullPrice = 120;
            context.Courses.Add(c);
            context.Courses.ToList();

            context.Courses.

            

            var courses = context.GetCourses();
            foreach (var c1 in courses)
            {
                Console.WriteLine(c.Description);
            }

           


            //context.Courses.Remove(null);

            //context.DeleteCourse(10);
            Console.ReadKey();
        }
    }
}
