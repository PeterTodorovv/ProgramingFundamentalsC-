using System;
using System.Linq;

namespace _02TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool emptySeats = false;

            for (int i = 0; i < lift.Length; i++)
            {
                int peopleThatCanGetOn = 4 - lift[i];
                if (peopleThatCanGetOn != 0)
                {
                    if (peopleWaiting >= peopleThatCanGetOn)
                    {
                        lift[i] = 4;
                        peopleWaiting -= peopleThatCanGetOn;
                    }
                    else
                    {
                        lift[i] += peopleWaiting;
                        peopleWaiting = 0;
                        emptySeats = true;
                        break;
                    }
                }
            }

            if (peopleWaiting > 0) Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
            else if (emptySeats) Console.WriteLine("The lift has empty spots!");
            Console.WriteLine(string.Join(" ", lift));
        }
    }
}
