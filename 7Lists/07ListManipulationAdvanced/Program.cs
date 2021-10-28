using System;
using System.Collections.Generic;
using System.Linq;

namespace _07ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool isManipulated = false;
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] splittedCommand = command.Split();
                string action = splittedCommand[0];

                if (action == "Add")
                {
                    int numberToAdd = int.Parse(splittedCommand[1]);
                    numbers.Add(numberToAdd);
                    isManipulated = true;
                }
                else if (action == "Remove")
                {
                    int numberToRemove = int.Parse(splittedCommand[1]);
                    numbers.Remove(numberToRemove);
                    isManipulated = true;
                }
                else if (action == "RemoveAt")
                {
                    int index = int.Parse(splittedCommand[1]);
                    numbers.RemoveAt(index);
                    isManipulated = true;
                }
                else if (action == "Insert")
                {
                    int numberToInsert = int.Parse(splittedCommand[1]);
                    int index = int.Parse(splittedCommand[2]);
                    numbers.Insert(index, numberToInsert);
                    isManipulated = true;
                }
                else if (action == "Contains")
                {
                    int numberToContain = int.Parse(splittedCommand[1]);
                    if (numbers.Contains(numberToContain)) Console.WriteLine("Yes");
                    else Console.WriteLine("No such number");
                }
                else if (action == "PrintEven")
                {
                    foreach(int number in numbers)
                    {
                        if (number % 2 == 0) Console.Write(number + " ");
                    }
                    Console.WriteLine();
                }
                else if (action == "PrintOdd")
                {
                    foreach (int number in numbers)
                    {
                        if (number % 2 == 1) Console.Write(number + " ");
                    }
                    Console.WriteLine();
                }
                else if(action == "GetSum")
                {
                    int sum = 0;
                    foreach(int number in numbers)
                    {
                        sum += number;
                    }
                    Console.WriteLine(sum);
                }
                else if (action == "Filter")
                {
                    string condition = splittedCommand[1];
                    int numberToCompare = int.Parse(splittedCommand[2]);
                    if(condition == "<")
                    {
                        foreach(int number in numbers)
                        {
                            if (number < numberToCompare) Console.Write(number + " ");
                        }
                        Console.WriteLine();
                    }
                    else if (condition == "<=")
                    {
                        foreach (int number in numbers)
                        {
                            if (number <= numberToCompare) Console.Write(number + " ");
                        }
                        Console.WriteLine();
                    }
                    else if (condition == ">")
                    {
                        foreach (int number in numbers)
                        {
                            if (number > numberToCompare) Console.Write(number + " ");
                        }
                        Console.WriteLine();
                    }
                    else if (condition == ">=")
                    {
                        foreach (int number in numbers)
                        {
                            if (number >= numberToCompare) Console.Write(number + " ");
                        }
                        Console.WriteLine();
                    }
                }
                command = Console.ReadLine();
            }
            if(isManipulated) Console.WriteLine(string.Join(" ", numbers));
               
        }
    }
}
