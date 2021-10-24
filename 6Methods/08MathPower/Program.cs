using System;

namespace _08MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = MathPower(number, power);
            Console.WriteLine(result);
        }

        static double MathPower(double number, double power)
        {
            double poweredNumber = number;
            for(int i = 2; i<= power; i++)
            {
                poweredNumber *= number;
            }
            return poweredNumber;
        }
    }
}
