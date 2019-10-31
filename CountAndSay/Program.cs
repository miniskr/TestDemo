using System;

namespace CountAndSay
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Solution.CountAndSay(5);

            Console.WriteLine($"Result: {result}");

            Console.ReadKey();
        }
    }
}
