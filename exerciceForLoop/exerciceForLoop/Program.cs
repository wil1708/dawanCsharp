using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciceForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 1, 2, 3 };

            foreach(var item in tab)
            {
                if (item == 1){
                    Console.WriteLine("nombre 1 existant");
                }
            }

            int[] tab2 = { 40, 20, 100, 30, -1, 70, -10, 500 };
            int near = 0;
            int good = tab2[0];

            for(int i = 0; i < tab2.Length; i++)
            {
                if(tab2[i] == near)
                {
                    good = tab2[i];
                    Console.WriteLine(i);
                }
                else if(tab2[i] > 0 && good >= (tab2[i] - near))
                {
                    good = tab2[i];
                    
                }
                
            }
            Console.WriteLine(good);


            int target = 0;
            int[] myArray = { /*-500,*/ -338, /*-79, -2, 4000, 3, 45,*/ 338, 6000 };
            int result = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == target)
                {
                    result = myArray[i];
                    Console.WriteLine(result);
                }
                else if (myArray[i] > 0 && result >= (myArray[i] - target))
                {
                    result = myArray[i];
                }
            }
            Console.WriteLine(result);

            int[] ints = { 1, 2, 3 };
            Console.WriteLine(Class1.Exists(ints, 102));

            Console.ReadLine();
        }
        
    }
}
