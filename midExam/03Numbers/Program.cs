using System;
using System.Collections.Generic;
using System.Linq;

namespace _03Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> topNumbers = new List<int>();
            double average = 0;

            foreach (var number in numbers)
            {
                average += number;
            }

            average /= numbers.Length;

            foreach(var number in numbers)
            {
                if (number > average)
                {
                    topNumbers.Add(number);
                }
            }

            topNumbers.Sort();
            topNumbers.Reverse();

            if(topNumbers.Count == 0)
            {
                Console.WriteLine("No");
            }
            else if (topNumbers.Count < 5)
            {
                for(int i = 0; i < topNumbers.Count; i++)
                {
                    Console.Write(topNumbers[i]+ " ");
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(topNumbers[i] + " ");
                }
            }

        }
    }
}
