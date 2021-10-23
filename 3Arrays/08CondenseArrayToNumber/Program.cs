using System;
using System.Linq;

namespace _08CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numbersLenght = numbers.Length;
            if(numbers.Length == 1)
            {
                Console.WriteLine(1);
                return;
            }
            for(int rows = 1; rows<=numbersLenght-2; rows++)
            {
                int[] newNumers = new int[numbers.Length - 1];
                for (int i = 1; i < numbers.Length-1; i += 1)
                {
                    if (i % 2 == 1 && numbers.Length > 2)
                    {
                        newNumers[i - 1] = numbers[i - 1] + numbers[i];
                        newNumers[i] = numbers[i + 1] + numbers[i];
                    }
                    if(numbers.Length % 2 == 0 && i == numbers.Length - 2)
                    {
                        newNumers[newNumers.Length - 1] = numbers[i] + numbers[i + 1];
                    }
                }
                numbers = newNumers;
            }
            Console.WriteLine(numbers[0] + numbers[1]);

        }
    }
}
