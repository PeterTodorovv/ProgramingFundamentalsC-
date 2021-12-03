using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var regex = @"(([\/|=])[A-Z][A-z]{3,}\2)";
            string[] match = Regex.Matches(input, regex).Cast<Match>()
            .Select(m => m.Value)
            .ToArray();

            string mathces = String.Join(' ', match);
            mathces = mathces.Replace('=', ' ');
            mathces = mathces.Replace('/', ' ');
            string[] locations = mathces.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string forPoints = String.Join("", locations);
            string destinations = String.Join(", ", locations);

            Console.WriteLine($"Destinations: {destinations}");
            Console.WriteLine($"Travel Points: {forPoints.Length}");
        }
    }
}
