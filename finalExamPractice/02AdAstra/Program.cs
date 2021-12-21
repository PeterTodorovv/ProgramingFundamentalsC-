using System;
using System.Text.RegularExpressions;

namespace _02AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(#|\|)[A-z]([A-z]| )+\1\d{2}\/\d{2}\/\d{2}\1\d+\1");
            var matches = regex.Matches(input);

            int calories = 0;
            foreach(Match match in matches)
            {
                if (match.Value.Contains("#"))
                {
                    string[] splittedMatch = match.Value.Split("#", StringSplitOptions.RemoveEmptyEntries);
                    calories += int.Parse(splittedMatch[2]);
                }
                else
                {
                    string[] splittedMatch = match.Value.Split("|", StringSplitOptions.RemoveEmptyEntries);
                    calories += int.Parse(splittedMatch[2]);
                }

            }

            Console.WriteLine($"You have food to last you for: {calories/2000} days!");

            foreach(Match item in matches)
            {
                if (item.Value.Contains("#"))
                {
                    string[] splittedMatch = item.Value.Split("#", StringSplitOptions.RemoveEmptyEntries);
                    Console.WriteLine($"Item: {splittedMatch[0]}, Best before: {splittedMatch[1]}, Nutrition: {splittedMatch[2]}");
                }
                else
                {
                    string[] splittedMatch = item.Value.Split("|", StringSplitOptions.RemoveEmptyEntries);
                    Console.WriteLine($"Item: {splittedMatch[0]}, Best before: {splittedMatch[1]}, Nutrition: {splittedMatch[2]}");
                }
            }
        }
    }
}
