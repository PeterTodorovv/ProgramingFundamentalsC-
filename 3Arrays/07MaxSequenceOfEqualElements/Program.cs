using System;
using System.Linq;

namespace _07MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lastestNumber = int.MinValue;
            int timesRepeated = 0;
            int maxTimesRepeated = 0;
            int reapeatedNumber = 0;
            foreach(int number in numbers)
            {
                if(number == lastestNumber)
                {
                    timesRepeated += 1;
                    if(maxTimesRepeated < timesRepeated)
                    {
                        maxTimesRepeated = timesRepeated;
                        reapeatedNumber = number;
                    }
                }
                else
                {
                    timesRepeated = 1;
                }
                lastestNumber = number;
            }
            for(int i = 1; i <= maxTimesRepeated; i++)
            {
                Console.Write(reapeatedNumber + " ");
            }
        }
    }
}
