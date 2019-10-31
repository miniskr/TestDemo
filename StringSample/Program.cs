using System;

namespace StringSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new string[]
                {
                                // index from start    index from end
                    "The",      // 0                   ^9
                    "quick",    // 1                   ^8
                    "brown",    // 2                   ^7
                    "fox",      // 3                   ^6
                    "jumped",   // 4                   ^5
                    "over",     // 5                   ^4
                    "the",      // 6                   ^3
                    "lazy",     // 7                   ^2
                    "dog"       // 8                   ^1
                };
            var x = 7;
            var y = 8;
            Range phrase = 1..4;
            var text = words[phrase];
            FormattableString s = $"The result of {x} + {y} is {x + y}";

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine($"{s.ToString()}");
            foreach (var arg in s.GetArguments())
            {
                Console.WriteLine($"| {{1}}                      {arg.ToString()}                                    |");
            }
            Console.WriteLine("-------------------------------------------------------------");

            var i = 2477;
            Console.WriteLine($"{i:n}  {i:e} {i:x} {i:c}");

            var person = new PersonFormat("Li", "Ming");

            Console.WriteLine(person.ToString("L"));
            Console.WriteLine($"{person:L}");

            Console.ReadLine();
        }
    }
}
