using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ");
            Dictionary<string, int> runners = new Dictionary<string, int>();

            foreach(var name in names)
            {
                runners.Add(name, 0);
            }

            var namesPattern = @"[A-Za-z]+";
            var digitsPattern = @"\d+";
            string input = Console.ReadLine();

            while(input!= "end of race")
            {
                MatchCollection matchedNames = Regex.Matches(input, namesPattern);
                MatchCollection matchedDigits = Regex.Matches(input, digitsPattern);
                string name = string.Join("", matchedNames);
                string stringDistance = string.Join("", matchedDigits);
                if (runners.ContainsKey(name))
                {
                    int distance = 0;
                    foreach(var digit in stringDistance)
                    {
                        distance += int.Parse(digit.ToString());
                    }
                    runners[name] += distance;
                }
                input = Console.ReadLine();
            }
            

            int position = 1;
            foreach(var runner in runners.OrderByDescending(v => v.Value))
            {
                if (position == 1)
                    Console.WriteLine($"1st place: {runner.Key}");
                else if (position == 2)
                    Console.WriteLine($"2nd place: {runner.Key}");
                else if (position == 3)
                    Console.WriteLine($"3rd place: {runner.Key}");
                else
                    break;

                position++;
            }
        }
    }
}
