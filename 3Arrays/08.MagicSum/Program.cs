using System;
using System.Linq;

namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i < numbers.Length-1; i++)
            {
                for(int secondNumber = i+1; secondNumber < numbers.Length; secondNumber++)
                {
                    if (numbers[i] + numbers[secondNumber] == number) Console.WriteLine($"{numbers[i]} {numbers[secondNumber]}");
                }
            }
        }
    }
}
