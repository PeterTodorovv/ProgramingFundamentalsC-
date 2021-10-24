using System;

namespace _04PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            PrintingTriangle(size);
        }

        static void PrintingTriangle(int size)
        {
            for(int row = 1; row <= size; row++)
            {
                PrintingCurrentHalf(row);
            }
            for (int row = size-1; row >= 1; row--)
            {
                PrintingCurrentHalf(row);
            }
        }

        private static void PrintingCurrentHalf(int row)
        {
            for (int i = 1; i <= row; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
