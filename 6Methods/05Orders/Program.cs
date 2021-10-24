using System;

namespace _05Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            Calculator(product, quantity);
        }

        static void Calculator (string product, int quantity)
        {
            switch (product)
            {
                case "coffee":
                    Console.WriteLine($"{(1.50 * quantity):f2}");
                    break;
                case "water":
                    Console.WriteLine($"{(1.00 * quantity):f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{(1.40 * quantity):f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{(2.00 * quantity):f2}");
                    break;
            }
        }
    }
}
