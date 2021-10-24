using System;

namespace _08FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = Math.Abs(int.Parse(Console.ReadLine()));
            int n2 = Math.Abs(int.Parse(Console.ReadLine()));

            long factorialN1 = CalculateFactorial(n1);
            long factorialN2 = CalculateFactorial(n2);

            double result = ((double)factorialN1) / factorialN2;
            Console.WriteLine($"{result:f2}");
        }

        static long CalculateFactorial(int number)
        {
            long factorial = 1;
            for(int i = number; i > 1; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
