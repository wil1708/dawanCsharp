using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_DataAnnotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Course cour = new Course();
            cour.Tags.Add(new Tag());
            cour.Author = new Author();

            Console.WriteLine(cour);


            Console.ReadKey();

        }
    }
}
