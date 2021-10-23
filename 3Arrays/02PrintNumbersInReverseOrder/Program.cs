using System;

namespace _02PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumbers = int.Parse(Console.ReadLine());
            int[] numbers = new int[totalNumbers];
            for(int i = 0; i <= totalNumbers-1; i++)
            {
                numbers[totalNumbers - i -1] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
