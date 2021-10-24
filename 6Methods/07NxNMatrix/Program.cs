using System;

namespace _07NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintNxN(number);

        }

        static void PrintNxN(int number)
        {
            for(int i = 1; i <= number; i++)
            {
                for(int l = 1; l <=number; l++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
