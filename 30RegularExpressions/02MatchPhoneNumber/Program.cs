using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            MatchCollection collection = Regex.Matches(input, @"(\+359([- ])2\2\d{3}\2\d{4}\b)");

            var matchedPhones = collection.Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
