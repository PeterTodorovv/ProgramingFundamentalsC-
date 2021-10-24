using System;

namespace _03Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    Add(a, b);
                    break;
                case "multiply":
                    Multiply(a, b);
                    break;
                case "subtract":
                    Subtract(a, b);
                    break;
                case "divide":
                    Divide(a, b);
                    break;
            }
        }

        static void Add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
        }

        static void Multiply(int a, int b)
        {
            int sum = a * b;
            Console.WriteLine(sum);
        }

        static void Subtract(int a, int b)
        {
            int result = a - b;
            Console.WriteLine(result);
        }
        static void Divide(int a, int b)
        {
            int result = a / b;
            Console.WriteLine(result);
        }

    }
}
