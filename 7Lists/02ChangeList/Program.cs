using System;
using System.Collections.Generic;
using System.Linq;

namespace _02ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] splittedCommand = command.Split();
                string action = splittedCommand[0];

                if (action == "Delete")
                {
                    int numberToRemove = int.Parse(splittedCommand[1]);
                    numbers.RemoveAll(x => x == numberToRemove);
                }
                else if(action == "Insert")
                {
                    int element = int.Parse(splittedCommand[1]);
                    int index = int.Parse(splittedCommand[2]);
                    numbers.Insert(index, element);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
