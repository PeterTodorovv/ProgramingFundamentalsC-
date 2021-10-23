using System;
using System.Linq;

namespace _10LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] field = new int[int.Parse(Console.ReadLine())];
            int[] ladybugsIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for(int i = 0; i < ladybugsIndexes.Length; i++)
            {
                int currentIndex = ladybugsIndexes[i];
                if (currentIndex>=0 && currentIndex < field.Length) 
                {
                    field[currentIndex] = 1;
                }
            }

            string command = String.Empty;

            while((command = Console.ReadLine()) != "end")
            {
                string[] arrayCommand = command.Split();
                if(arrayCommand[1] == "right")
                {
                    int startingPosotion = int.Parse(arrayCommand[0]);
                    field[startingPosotion] = 0;
                    int cellsToMove = int.Parse(arrayCommand[2]);
                    int newPosition = startingPosotion + cellsToMove;
                    if (newPosition > field.Length - 1);
                    else
                    {
                        while (newPosition <= field.Length - 1)
                            if (field[newPosition] == 0) 
                            { 
                                field[newPosition] = 1;
                                break;
                            }
                            else
                            {
                                newPosition = newPosition + cellsToMove;
                            }
                    }
                }
                else if (arrayCommand[1] == "left")
                {
                    int startingPosotion = int.Parse(arrayCommand[0]);
                    field[startingPosotion] = 0;
                    int cellsToMove = int.Parse(arrayCommand[2]);
                    int newPosition = startingPosotion - cellsToMove;
                    if (newPosition < 0) ;
                    else
                    {
                        while (newPosition >= 0)
                            if (field[newPosition] == 0)
                            {
                                field[newPosition] = 1;
                                break;
                            }
                            else
                            {
                                newPosition = newPosition - cellsToMove;
                            }
                    }
                }
                
            }

            Console.WriteLine(String.Join(" ", field));

        }
    }
}
