using System;

namespace _09SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentYield = int.Parse(Console.ReadLine());
            int totalSpice = 0;
            int totalDays = 0;
            while (currentYield >= 100)
            {
                totalSpice += currentYield;

                if (totalSpice >= 26) totalSpice -= 26;
                else totalSpice = 0;

                currentYield -= 10;
                totalDays++;
            }
            if (totalSpice >= 26) totalSpice -= 26;
            else totalSpice = 0;
            
            Console.WriteLine($"{totalDays}\n{totalSpice}");
        }
    }
}
