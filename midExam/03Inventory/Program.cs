using System;
using System.Collections.Generic;
using System.Linq;

namespace _03Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> materials = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            while(input != "Craft!")
            {
                string[] splittedInput = input.Split(" - ");
                string command = splittedInput[0];

                if(command == "Collect")
                {
                    string item = splittedInput[1];

                    if (!materials.Contains(item)) materials.Add(item);
                }
                else if(command == "Drop")
                {
                    string item = splittedInput[1];

                    if (materials.Contains(item))
                    {
                        materials.Remove(item);
                    }
                }
                else if(command == "Combine Items")
                {
                    string[] items = splittedInput[1].Split(':');
                    string oldItem = items[0];
                    string newItem = items[1];

                    if (materials.Contains(oldItem))
                    {
                        int indexOfOld = materials.IndexOf(oldItem);
                        materials.Insert(indexOfOld + 1, newItem);
                    }
                }
                else if(command == "Renew")
                {
                    string item = splittedInput[1];
                    if (materials.Contains(item))
                    {
                        materials.Remove(item);
                        materials.Add(item);
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", materials));
        }
    }
}
