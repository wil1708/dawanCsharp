using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_CodeFirstDetail
{
    class Program
    {
        static void Main(string[] args)
        {
            MyContext context = new MyContext();

            Console.WriteLine("Contenu de la table HistoryMigrations:");

            MigrationHistoryTable.getMigrations();

            Console.ReadKey();
           
        }
    }
}
