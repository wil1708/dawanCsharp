// See https://aka.ms/new-console-template for more information
using HelloWorld2;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.MaxSpeed = 100;
            Console.WriteLine(car.Name + " goes at ");


            Car audi = new Car("audi a4");
            audi.Drive();
            audi.Details();

            Car bmw = new Car("BMW M5", 350, "red");
            bmw.Drive();
            bmw.Details();

            Console.WriteLine("press 1 to stop the car");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                audi.Stop();
            }
            else
            {
                Console.WriteLine("Car drives indefinetely");
            }

            Members member1 = new Members();
            member1.Introducing(true);
            Console.ReadKey();

        }





    }
}







