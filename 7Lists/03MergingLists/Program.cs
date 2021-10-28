using System;
using System.Collections.Generic;
using System.Linq;

namespace _03MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> firstList = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> secondList = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> newList = new List<double>();

            if(firstList.Count >= secondList.Count)
            {
                for(int i = 0; i < firstList.Count; i++)
                {
                    newList.Add(firstList[i]);
                    if (secondList.Count > i) newList.Add(secondList[i]);
                }
            }
            else
            {
                for (int i = 0; i < secondList.Count; i++)
                {
                    if (firstList.Count > i) newList.Add(firstList[i]);
                    newList.Add(secondList[i]);
                }
            }
            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
