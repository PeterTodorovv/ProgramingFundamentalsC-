using System;

namespace _01Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] people = new int[lines];
            int totalPeople = 0;

            for(int i = 0; i < lines; i++)
            {
                int peopleGettingOn = int.Parse(Console.ReadLine());
                totalPeople += peopleGettingOn;
                people[i] = peopleGettingOn;
            }
            Console.WriteLine(String.Join(" ", people));
            Console.WriteLine(totalPeople);
        }
    }
}
