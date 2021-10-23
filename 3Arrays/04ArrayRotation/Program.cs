using System;
using System.Linq;

namespace _04ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for(int i = 1; i <= rotations; i++)
            {
                int temp = numbers[0];
                for (int index = 0; index< numbers.Length-1; index++)
                {
                    numbers[index] = numbers[index + 1];
                }
                numbers[numbers.Length - 1] = temp;
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
