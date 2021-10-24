using System;

namespace _05MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            FindNumberSign(a, b, c);
        }

        static void FindNumberSign(double a, double b, double c)
        {
            if(a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("zero");
                return;
            }

            int negativesCount = 0;
            if (a < 0) negativesCount++;
            if (b < 0) negativesCount++;
            if (c < 0) negativesCount++;


            if(negativesCount % 2 == 1)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
    }
}
