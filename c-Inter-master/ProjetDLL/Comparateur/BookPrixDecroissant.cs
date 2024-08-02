using ProjetDLL.ExpressionLambda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Comparateur
{
    public class BookPrixDecroissant : IComparer<Book>
    {
        public int Compare(Book b1, Book b2)
        {
            if (b1.Price == b2.Price)
            {
                return 0;
            }
            else if (b1.Price < b2.Price)
            {
                return 1;
            }
            else
            {
                return -1;
            }

        }
    }
}
