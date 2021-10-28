using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> vagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while(command != "end")
            {
                string[] splittedCommand = command.Split();

                if(splittedCommand[0] == "Add")
                {
                    vagons.Add(int.Parse(splittedCommand[1]));
                }
                else
                {
                    int passengersToAdd = int.Parse(splittedCommand[0]);
                    for(int i = 0; i < vagons.Count; i++)
                    {
                        if(passengersToAdd + vagons[i] <= maxCapacity)
                        {
                            vagons[i] += passengersToAdd;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", vagons));
        }
    }
}
