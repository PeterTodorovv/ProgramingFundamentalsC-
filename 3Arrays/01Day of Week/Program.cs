using System;

namespace _01Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfTheWeek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            int day = int.Parse(Console.ReadLine()) - 1;
            if (day > 6 || day<0) Console.WriteLine("Invalid day!");
            else Console.WriteLine(daysOfTheWeek[day]);
        }
    }
}
