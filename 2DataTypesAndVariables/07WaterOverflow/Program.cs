using System;

namespace _07WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int maxCapacity = 255;
            int currentCapacity = 0;
            
            for(int i = 1; i <= numberOfLines; i++)
            {
                int litersAdded = int.Parse(Console.ReadLine());
                if(currentCapacity + litersAdded <= maxCapacity)
                {
                    currentCapacity += litersAdded;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(currentCapacity);
        }
    }
}
