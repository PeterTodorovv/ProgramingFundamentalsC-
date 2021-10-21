using System;

namespace _9SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            for(int i = 1; i <= n*2; i+=2)
            {
                total += i;
                Console.WriteLine(i);
            }
            Console.WriteLine($"Sum: {total}");
        }
    }
}
