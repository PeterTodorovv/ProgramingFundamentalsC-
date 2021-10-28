using System;
using System.Collections.Generic;
using System.Linq;

namespace _05RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).Where(x => x >= 0).ToList();

            if (numbers.Count == 0) Console.WriteLine("empty");
            else
            {
                numbers.Reverse();
                Console.WriteLine(string.Join(" ", numbers));
            }
            

        }
    }
}
