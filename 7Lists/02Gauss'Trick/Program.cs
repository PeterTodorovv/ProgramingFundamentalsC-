using System;
using System.Collections.Generic;
using System.Linq;

namespace _02Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            List<double> newNumbers = new List<double>();
            if(inputNumbers.Length % 2 == 1)
            {
                for(int i = 0; i < inputNumbers.Length / 2; i++)
                {
                    double numberToAdd = inputNumbers[i] + inputNumbers[inputNumbers.Length - i - 1];
                    newNumbers.Add(numberToAdd);
                }
                newNumbers.Add(inputNumbers[inputNumbers.Length / 2]);
            }
            else
            {
                for (int i = 0; i < inputNumbers.Length / 2; i++)
                {
                    double numberToAdd = inputNumbers[i] + inputNumbers[inputNumbers.Length - i - 1];
                    newNumbers.Add(numberToAdd);
                }
            }
            Console.WriteLine(string.Join(" ", newNumbers));
        }
    }
}
