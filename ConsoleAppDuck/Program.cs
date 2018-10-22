using System;

namespace ConsoleAppDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Duck patoMallard = new MallardDuck();
            patoMallard.display();
           ///pato 1
           ///

            Console.ReadKey();
        }
    }
}
