using System;

namespace _11Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte snowBalls = byte.Parse(Console.ReadLine());
            int biggestValue = 0;
            short biggestSnow = 0;
            short biggestTime = 0;
            short biggestQuality = 0; 
            for (int i = 1; i <= snowBalls; i++)
            {
                short snowballSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                byte snowballQuality = byte.Parse(Console.ReadLine());
                int snowballValue = (int)(Math.Pow(snowballSnow / snowballTime, snowballQuality));
                if (snowballValue > biggestValue)
                {
                    biggestValue = snowballValue;
                    (biggestSnow, biggestTime, biggestQuality) = (snowballSnow, snowballTime, snowballQuality);
                }
            }
            Console.WriteLine($"{biggestSnow} : {biggestTime} = {biggestValue} ({biggestQuality})");
        }
    }
}
