using System;

namespace _01ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            decimal kilometers = (decimal)(meters / 1000.0);
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
