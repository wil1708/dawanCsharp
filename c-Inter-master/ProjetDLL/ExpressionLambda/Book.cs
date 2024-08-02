using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ExpressionLambda
{
    public class Book : IComparable
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            Book b = (Book)obj;
            return this.Price.CompareTo(b.Price);
        }

        public override bool Equals(object obj)
        {
            return obj is Book book &&
                   Title == book.Title &&
                   Price == book.Price;
        }


    }
}
