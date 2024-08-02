using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciceForLoop
{
    public class Class1
    {
        public static bool Exists(int[] ints, int k)
        {
            bool numExists = false;
            foreach (var item in ints)
            {
                if (item == k)
                {
                    numExists = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return numExists;

        }
    }
}
