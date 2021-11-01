using System;
using System.Collections.Generic;
using System.Linq;

namespace _02CoffeeLover
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coffees = Console.ReadLine().Split().ToList();
            int commands = int.Parse(Console.ReadLine());

            for(int i = 1; i <= commands; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];

                if(command == "Include")
                {
                    string coffee = input[1];
                    coffees.Add(coffee);
                }
                else if(command == "Remove")
                {
                    string position = input[1];
                    int coffeesToRemove = int.Parse(input[2]);

                    if(coffeesToRemove > coffees.Count)
                    {
                        continue;
                    }

                    for(int x = 1; x <= coffeesToRemove; x++)
                    {
                        if (position == "first") coffees.RemoveAt(0);
                        else coffees.RemoveAt(coffees.Count -1);
                    }
                }
                else if(command == "Prefer")
                {
                    int firstIndex = int.Parse(input[1]);
                    int secondIndex = int.Parse(input[2]);

                    if(firstIndex >=0 && firstIndex < coffees.Count && secondIndex >= 0 && secondIndex < coffees.Count)
                    {
                        string firstCoffee = coffees[firstIndex];
                        coffees[firstIndex] = coffees[secondIndex];
                        coffees[secondIndex] = firstCoffee;
                    }
                }
                else if (command == "Reverse")
                {
                    coffees.Reverse();
                }
            }
            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ", coffees));
        }
    }
}
