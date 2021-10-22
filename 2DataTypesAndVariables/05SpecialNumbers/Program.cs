using System;

namespace _05SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i<=startingNumber; i++)
            {
                int sum = 0;
                int wholeNumber = i;
                while (wholeNumber > 0)
                {
                    sum += wholeNumber % 10;
                    wholeNumber /= 10;
                }
                Console.WriteLine($"{i} -> {sum==5 || sum == 7 || sum == 11}");
            }
        }
    }
}
