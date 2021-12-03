using System;
using System.Collections.Generic;
using System.Linq;

namespace _03PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> plantsRating = new Dictionary<string, List<int>>();
            Dictionary<string, int> plantsRerity = new Dictionary<string, int>();

            for(int i = 1; i <= lines; i++)
            {
                string[] inputFlowers = Console.ReadLine().Split("<->");
                string flower = inputFlowers[0];
                int rarity = int.Parse(inputFlowers[1]);
                plantsRating.Add(flower, new List<int>());
                plantsRerity.Add(flower, rarity);
            }

            string input = Console.ReadLine();

            while(input != "Exhibition")
            {
                string[] splittedInput = input.Split();
                string command = splittedInput[0];

                if(command == "Rate:")
                {
                    string flower = splittedInput[1];
                    int rating = int.Parse(splittedInput[3]);
                    plantsRating[flower].Add(rating);
                }
                else if(command == "Update:")
                {
                    string flower = splittedInput[1];
                    int rarity = int.Parse(splittedInput[3]);
                    plantsRerity[flower] = rarity;
                }
                else if(command == "Reset:")
                {
                    string flower = splittedInput[1];
                    plantsRating[flower] = new List<int>();
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var plant in plantsRerity.OrderByDescending(key => key.Key))
            {
                string flowerName = plant.Key;
                int rearity = plant.Value;
                double averageRating = 0;

                if(plantsRating.Count != 0)
                {
                    for(int i = 0; i < plantsRating[flowerName].Count; i++)
                        {
                            averageRating += plantsRating[flowerName][i];
                        }
                }
                

                averageRating /= plantsRating[flowerName].Count;
                Console.WriteLine($"- {plant.Key}; Rarity: {rearity}; Rating: {averageRating:f2}");
            }
        }
    }
}
