using System;
using System.Linq;

namespace _10LadyBugsV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladybugsIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] field = new int[fieldSize];

            for (int i = 0; i < ladybugsIndexes.Length; i++)
            {
                int currentIndex = ladybugsIndexes[i];
                if (currentIndex >= 0 && currentIndex < field.Length)
                {
                    field[currentIndex] = 1;
                }
            }

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] elements = command.Split();
                int ladyBugIndex = int.Parse(elements[0]);
                field[ladyBugIndex] = 0;
                int flyLenght = int.Parse(elements[2]);
                string direction = elements[1];

                if(ladyBugIndex < 0 || ladyBugIndex > field.Length -1 || field[ladyBugIndex] == 0)
                {
                    continue;
                }

                if(direction == "right")
                {
                    int landIndex = ladyBugIndex + flyLenght;

                    if(landIndex > field.Length - 1)
                    {
                        continue;
                    }

                    if(field[landIndex] == 1)
                    {
                        while(field[landIndex] == 1)
                        {
                            landIndex += flyLenght;
                            if (landIndex > field.Length - 1) break;
                        }
                    }
                    if (landIndex >= 0 && landIndex <= field.Length - 1) field[landIndex] = 1;
                }
                else if (direction == "left")
                {
                    int landIndex = ladyBugIndex - flyLenght;

                    if (landIndex < 0)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flyLenght;
                            if (landIndex < 0) break;
                        }
                    }
                    if (landIndex >= 0 && landIndex <= field.Length - 1) field[landIndex] = 1;
                }
            }
            Console.WriteLine(String.Join(' ', field));
        }       
    }
}
