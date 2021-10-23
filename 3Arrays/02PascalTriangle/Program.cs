using System;

namespace _02PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[] lastRow = { 1 };
            Console.WriteLine(1);
            for(int i = 2; i<=rows; i++)
            {
                int[] currentRow = new int[lastRow.Length + 1];
                currentRow[0] = 1;
                for(int p = 1; p < currentRow.Length - 1; p++)
                {
                    currentRow[p] = lastRow[p - 1] + lastRow[p];
                }
                currentRow[currentRow.Length - 1] = 1;
                Console.WriteLine(String.Join(" ", currentRow));
                lastRow = currentRow;
            }
        }
    }
}
