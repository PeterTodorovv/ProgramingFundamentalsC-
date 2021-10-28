using System;
using System.Collections.Generic;
using System.Linq;

namespace _03HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for(int i = 1; i <= numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                string name = command[0];
                if (command.Length == 3)
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
                else if(command.Length == 4)
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            foreach(var name in guests)
            {
                Console.WriteLine(name);
            }
        }
    }
}
