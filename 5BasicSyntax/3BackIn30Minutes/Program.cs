using System;

namespace _3BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine())+30;

            if (minutes >= 60)
            {
                minutes -= 60;
                hours++;
            }
            if(hours == 24)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
