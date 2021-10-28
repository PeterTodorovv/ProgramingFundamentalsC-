using System;
using System.Collections.Generic;
using System.Linq;

namespace _06ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while(command != "end")
            {
                string[] splittedCommand = command.Split();
                string action = splittedCommand[0];

                if(action == "Add")
                {
                    int numberToAdd = int.Parse(splittedCommand[1]);
                    numbers.Add(numberToAdd);
                }
                else if(action == "Remove")
                {
                    int numberToRemove = int.Parse(splittedCommand[1]);
                    numbers.Remove(numberToRemove);
                }
                else if(action == "RemoveAt")
                {
                    int index = int.Parse(splittedCommand[1]);
                    numbers.RemoveAt(index);
                }
                else if(action == "Insert")
                {
                    int numberToInsert = int.Parse(splittedCommand[1]);
                    int index = int.Parse(splittedCommand[2]);
                    numbers.Insert(index, numberToInsert);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
