using System;
using System.Linq;

namespace _05TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string validNumbers = "";
            int biggestNumber = int.MinValue;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] > numbers[i + 1]) validNumbers += $"{numbers[i]} ";
            }
            validNumbers += numbers[numbers.Length - 1];
            Console.WriteLine(validNumbers);
        }
    }
}
