using System; 

namespace HelloWorld
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: "); 
            string input = Console.ReadLine();
            Console.WriteLine("Enter a second number: ");
            string input2 = Console.ReadLine();

            int result = Convert.ToInt32(input) + Convert.ToInt32(input2);
            Console.WriteLine(result);
            Console.Read();
        }

        
    }
}
