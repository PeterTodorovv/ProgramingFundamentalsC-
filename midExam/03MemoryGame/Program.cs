using System;
using System.Collections.Generic;
using System.Linq;

namespace _03MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            string input = Console.ReadLine();
            int moves = 0;

            while(input != "end")
            {
                string[] splittedInput = input.Split();
                int index1 = int.Parse(splittedInput[0]);
                int index2 = int.Parse(splittedInput[1]);

                if(numbers.Count == 0)
                {

                }
                else if(index1 >= numbers.Count || index1 < 0 || index2 >= numbers.Count || index2 < 0 || index1 == index2)
                {
                    moves++;
                    string elementToInsert = "-" + moves + "a";
                    numbers.Insert(numbers.Count / 2, elementToInsert);
                    numbers.Insert(numbers.Count / 2, elementToInsert);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if(numbers[index1] == numbers[index2])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {numbers[index1]}!");
                    string element = numbers[index1];
                    numbers.Remove(element);
                    numbers.Remove(element);
                    moves++;
                }
                else if(numbers[index1] != numbers[index2])
                {
                    Console.WriteLine("Try again!");
                    moves++;
                }
                input = Console.ReadLine();
            }

            if(numbers.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine($"You have won in {moves} turns!");
            }

        }
    }
}
