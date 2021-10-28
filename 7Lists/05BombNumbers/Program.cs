using System;
using System.Collections.Generic;
using System.Linq;

namespace _05BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numberBomb = bomb[0];
            int power = bomb[1];
            int indexOfBomb = numbers.IndexOf(numberBomb);

            while(indexOfBomb != -1)
            {
                for (int i = 1; i <= power; i++)
                {
                
                    if(indexOfBomb + 1 < numbers.Count) numbers.RemoveAt(indexOfBomb + 1);
                    if(indexOfBomb - 1 >= 0) numbers.RemoveAt(indexOfBomb - 1);
                    indexOfBomb = numbers.IndexOf(numberBomb);
                }
                numbers.RemoveAt(indexOfBomb);
                indexOfBomb = numbers.IndexOf(numberBomb);
            }

            int sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
