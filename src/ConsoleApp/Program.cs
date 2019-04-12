using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Calculate();

            Console.ReadKey();
        }

        [LogCall]
        private static void Calculate()
        {
            Console.WriteLine("Calculate");
        }

    }
}
