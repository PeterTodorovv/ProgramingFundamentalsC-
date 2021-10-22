using System;

namespace _02PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());
            decimal dollars = (decimal)(pounds * 1.31);
            Console.WriteLine($"{dollars:f3}");
        }
    }
}
