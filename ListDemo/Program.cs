using System;
using System.Collections.Generic;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var graham = new Racer(1, "Graham", "Hill", "UK", 14);
            var emerson = new Racer(2, "Emerson", "Fittipaldi", "Brazil", 14);
            var mario = new Racer(3, "Mario", "Andretti", "USA", 12);

            var racers = new List<Racer>() { graham, emerson, mario };

            var indexof = racers.IndexOf(mario);

            var findIndex = racers.FindIndex(new FindCountry("USA").FindCountryPredict);

            var index3 = racers.FindIndex(x => x.Country == "USA");

            Console.WriteLine($"findIndex:{findIndex}");
            Console.WriteLine($"index3:{index3}");
            Console.ReadKey();
        }
    }
}
