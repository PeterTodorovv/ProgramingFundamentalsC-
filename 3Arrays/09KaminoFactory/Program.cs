using System;
using System.Linq;

namespace _09KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            byte length = byte.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int[] bestDna = { };
            byte sempleNumber = 0;
            byte maxTimesRepeared = 0;
            byte leftestIndex = 101;
            byte currentSempleNumber = 0;
            byte totalOnes = 0;
            while (command!= "Clone them!")
            {
                int[] dna = command.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                byte timesReapeated = 0;
                byte currentIndex = 0;
                currentSempleNumber++;
                for(byte i = 0; i < dna.Length; i++)
                {
                    byte sum = 0;
                    int digit = dna[i];
                    if (digit == 1)
                    {
                        timesReapeated ++;
                        currentIndex = i;
                    }
                    else
                    {
                        foreach (byte number in dna)
                        {
                            sum += number;
                        }
                        if (timesReapeated > maxTimesRepeared || (timesReapeated == maxTimesRepeared && leftestIndex > currentIndex - timesReapeated + 1)
                            ||
                            (timesReapeated == maxTimesRepeared && leftestIndex == currentIndex - timesReapeated + 1 && totalOnes< sum))
                        {
                            
                            maxTimesRepeared = timesReapeated;
                            bestDna = dna;
                            leftestIndex = (byte)(currentIndex - timesReapeated + 1);
                            sempleNumber = currentSempleNumber;
                            timesReapeated = 0;
                            totalOnes = sum;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {sempleNumber} with sum: {totalOnes}.\n{String.Join(" ", bestDna)}");
        }
    }
}
