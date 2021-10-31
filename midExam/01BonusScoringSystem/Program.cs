using System;

namespace _01BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numberOfLectures = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());
            double maxBonus = 0;
            int attandedLectures = 0;

            //{total bonus} = {student attendances} / {course lectures} * (5 + {additional bonus})

            for (int i = 1; i <= numberOfStudents; i++)
            {
                int attendace = int.Parse(Console.ReadLine());
                double totalBonus = (double)attendace / numberOfLectures * (5 + bonus);

                if(totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    attandedLectures = attendace;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.\nThe student has attended {attandedLectures} lectures.");
        }
    }
}
