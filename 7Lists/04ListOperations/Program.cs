using System;
using System.Collections.Generic;
using System.Linq;

namespace _04ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while(command != "End")
            {
                string[] splittedCommand = command.Split();
                string action = splittedCommand[0];

                if(action == "Add")
                {
                    int number = int.Parse(splittedCommand[1]);
                    numbers.Add(number);
                }
                else if(action == "Insert")
                {
                    int number = int.Parse(splittedCommand[1]);
                    int index = int.Parse(splittedCommand[2]);

                    if (index < numbers.Count && index >=0) numbers.Insert(index, number);
                    else Console.WriteLine("Invalid index");
                }
                else if(action == "Remove")
                {
                    int index = int.Parse(splittedCommand[1]);

                    if (index < numbers.Count && index >= 0) numbers.RemoveAt(index);
                    else Console.WriteLine("Invalid index");
                    
                }
                else if(action == "Shift")
                {
                    string direction = splittedCommand[1];
                    int repeats = int.Parse(splittedCommand[2]);

                    if (direction == "left")
                    {
                        for (int i = 1; i <= repeats; i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                    }
                    else if(direction == "right")
                    {
                        for (int i = 1; i <= repeats; i++)
                        {
                            numbers.Insert(0, numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
