using System;
using System.Text.RegularExpressions;

namespace _03MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var regex = @"\b(?<day>\d{2})(\.|-|\/)(?<month>[A-z]{3})\2(?<year>\d{4})\b";
            var dates = Regex.Matches(input, regex);

            foreach (Match date in dates)
            {
                Console.WriteLine($"Day: {date.Groups["day"].Value}, Month: {date.Groups["month"].Value}, Year: {date.Groups["year"].Value}");
            }
        }
    }
}
