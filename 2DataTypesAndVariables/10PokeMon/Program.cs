using System;

namespace _10PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int pokes = 0;
            int currentPower = pokePower;

            while (currentPower >= distance)
            {
                pokes++;
                currentPower -= distance;
                if (currentPower * 2 == pokePower && currentPower!=0 && exhaustionFactor!=0) currentPower /= exhaustionFactor;
            }
            Console.WriteLine($"{currentPower}\n{pokes}");
        }
    }
}
