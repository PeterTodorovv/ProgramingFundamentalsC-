using System;
using System.Linq;

namespace _03Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] evenPosition = new int[lines];
            int[] oddPosition = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                int[] newNumers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if(i % 2 == 0)
                {
                    evenPosition[i] = newNumers[0];
                    oddPosition[i] = newNumers[1];
                }
                else
                {
                    evenPosition[i] = newNumers[1];
                    oddPosition[i] = newNumers[0];
                }
            }
            Console.WriteLine(String.Join(" ", evenPosition));
            Console.WriteLine(String.Join(" ", oddPosition));
        }
    }
}
