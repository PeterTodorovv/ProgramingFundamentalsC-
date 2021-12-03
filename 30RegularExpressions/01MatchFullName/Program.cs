using System;
using System.Text.RegularExpressions;

namespace _01MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            MatchCollection newCollection = Regex.Matches(input, @"\b[A-Z][a-z]+ \b[A-Z][a-z]+");

            foreach(Match match in newCollection)
            {
                Console.Write(match + " ");
            }
        }
    }
}
