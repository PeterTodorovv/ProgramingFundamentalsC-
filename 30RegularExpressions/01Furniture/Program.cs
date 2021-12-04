using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalSum = 0;
            List<string> furnitures = new List<string>();
            Regex regex = new Regex(@">>([A-Z][A-z]+)<<(\d+.*\d*)!(\d+)");

            while(input != "Purchase")
            {
                if (regex.IsMatch(input))
                {
                    Match match = Regex.Match(input, @">>([A-Z][A-z]+)<<(\d+.*\d*)!(\d+)");
                    furnitures.Add(match.Groups[1].Value);
                    totalSum += double.Parse(match.Groups[2].Value) * int.Parse(match.Groups[3].Value);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            foreach(var furniture in furnitures)
            {
                Console.WriteLine(furniture);
            }

            Console.WriteLine($"Total money spend: {totalSum:f2}");
        }
    }
}
