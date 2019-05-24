using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            object thing;

            number = 42;

            thing = number;

            number = (int)thing;

            Console.WriteLine("Hello World!");
        }
    }
}
