using System;

namespace _01SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int totalWorkforce = firstEmployee + secondEmployee + thirdEmployee;
            int hoursNeeded;

            if (studentsCount % totalWorkforce != 0)
            {
                hoursNeeded = studentsCount / totalWorkforce + 1;
            }
            else
            {
                hoursNeeded = studentsCount / totalWorkforce;
            }
            int restTime = hoursNeeded / 3;
            if (hoursNeeded % 3 == 0 && hoursNeeded != 0) restTime--;
            int totalHours = hoursNeeded + restTime;
            Console.WriteLine($"Time needed: {totalHours}h.");
        }
    }
}
